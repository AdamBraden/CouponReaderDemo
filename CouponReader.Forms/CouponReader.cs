using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.UserActivities;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace CouponReaderDemo.Forms
{
    public partial class CouponReader : Form
    {
        // Private for UserActivities/Windows Timeline
        private UserActivitySession _currentSession;

        public CouponReader()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            #region initial setup
            // hook up button events
            scanButton.Click += new EventHandler(OnScanButtonClick);
            clearButton.Click += new EventHandler(OnClearButtonClick);
            historyButton.Click += new EventHandler(OnHistoryButtonClick);

            //set initial UX
            headerGroupBox.Visible = false;
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.BringToFront();
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\logo_horizontal-b.png");
            #endregion

            // Set supported inking device types.
            inkCanvas1.InkPresenter.InputDeviceTypes =
                CoreInputDeviceTypes.Mouse |
                CoreInputDeviceTypes.Pen |
                CoreInputDeviceTypes.Touch;

        }
        private void OnScanButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputCode.Text))
            {
                return;
            }

            // Find coupon in the CouponService
            var coupon = CouponsService.Instance.FindCouponByCode(txtInputCode.Text);
            if (coupon == null)
            {
                return;
            }

            // Display details and init history
            couponDetailsControl1.Init(coupon);
            couponHistoryControl1.Init(new CouponViewModel(coupon));
            tabControl1.SelectTab(0);

        }

        private async void OnLogonButton_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();

            var success = await loginService.SignInAsync();
            //var success = await loginService.WindowsHelloSignInAsync();

            if (success)
            {
                System.Diagnostics.Debug.WriteLine("Successful login");

                // setup UX
                loginPanel.Visible = false;
                headerGroupBox.Visible = true;
                tabControl1.Dock = DockStyle.Fill;


                // Send a Toast Notification and log info to Windows Timeline
                //ShowPictureOfTheDay();
                //await CreateUserActivityAsync();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("The Sign In process could not be completed successfully.");
            }
        }
        private void ShowPictureOfTheDay()
        {
            string title = "Welcome! Here's the featured picture of the day";
            string content = "beautiful scenery";
            string image = "https://picsum.photos/360/180?image=104";
            string logo = "https://picsum.photos/64?image=883";

            //xml schema for the toast notification
            string xmlString =
            $@"<toast><visual>
                <binding template='ToastGeneric'>
                <text>{title}</text>
                <text>{content}</text>
                <image src='{image}'/>
                <image src='{logo}' placement='appLogoOverride' hint-crop='circle'/>
                </binding>
                </visual></toast>";

            XmlDocument toastXml = new XmlDocument();
            toastXml.LoadXml(xmlString);

            //Create & Show toast
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        async Task CreateUserActivityAsync()
        {
            // Get channel and create activity.
            UserActivityChannel channel = UserActivityChannel.GetDefault();
            UserActivity activity = await channel.GetOrCreateUserActivityAsync("Coupon Reader");

            // Set deep-link and properties.
            activity.VisualElements.DisplayText = "DevIntersection Demo - Coupon Scanned!";
            activity.ActivationUri = new Uri("DevIntersectionDemo://page?MainPage");

            // Save to activity feed.
            await activity.SaveAsync();

            // Dispose prevsion session, Create a new session which indicates that the user is engaged in the activity.
            _currentSession?.Dispose();
            _currentSession = activity.CreateSession();
        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            txtInputCode.Text = string.Empty;
            couponDetailsControl1.Init(null);

            // Clear the InkCanvas
            inkCanvas1.InkPresenter.StrokeContainer.Clear();

        }
        private void OnHistoryButtonClick(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }
    }
}
