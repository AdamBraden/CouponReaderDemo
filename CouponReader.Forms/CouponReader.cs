using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponReaderDemo.Forms
{
    public partial class CouponReader : Form
    {
        public CouponReader()
        {
            InitializeComponent();
            InitForm();
        }
        private void InitForm()
        {
            scanButton.Click += new EventHandler(OnScanButtonClick);
            clearButton.Click += new EventHandler(OnClearButtonClick);
            historyButton.Click += new EventHandler(OnHistoryButtonClick);
            couponDetailsControl1.Dock = DockStyle.Fill;
            couponHistoryControl1.Dock = DockStyle.Fill;
            loginPanel.Dock = DockStyle.Fill;

            couponHistoryControl1.Visible = false;
            couponDetailsControl1.Visible = false;
            headerGroupBox.Visible = false;

            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "images\\logo_horizontal-b.png");

        }
        private void OnScanButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInputCode.Text))
            {
                return;
            }

            var coupon = CouponsService.Instance.FindCouponByCode(txtInputCode.Text);

            if (coupon == null)
            {
                return;
            }

            couponDetailsControl1.Init(coupon);
            couponHistoryControl1.Init(new CouponViewModel(coupon));
            ShowCouponDetails(true);

        }

        private void OnClearButtonClick(object sender, EventArgs e)
        {
            txtInputCode.Text = string.Empty;
            couponDetailsControl1.Init(null);
            couponDetailsControl1.Visible = false;
            couponHistoryControl1.Visible = false;
        }

        private void OnHistoryButtonClick(object sender, EventArgs e)
        {
            ShowCouponDetails(false);
        }

        private void ShowCouponDetails(bool show)
        {
            couponHistoryControl1.Visible = !show;
            couponDetailsControl1.Visible = show;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var loginService = new LoginService();

            var success = await loginService.SignInAsync();
            //var success = await loginService.WindowsHelloSignInAsync();

            if (success)
            {
                System.Diagnostics.Debug.WriteLine("Successful login");
                loginPanel.Visible = false;
                headerGroupBox.Visible = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("The Sign In process could not be completed successfully.");
            }
        }
    }
}
