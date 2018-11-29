using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CouponReaderDemo.Forms
{
    public partial class CouponDetailsControl : UserControl
    {
        public CouponDetailsControl()
        {
            InitializeComponent();
        }
        public void Init(Coupon coupon)
        {
            if (coupon != null)
            {
                titleText.Text = coupon.Code;
                userText.Text = coupon.User;
                usernameText.Text = coupon.UserName;
                couponText.Text = coupon.CouponText;
                expirationText.Text = coupon.Expiration.ToLongDateString();
                couponImage.ImageLocation = coupon.ImageUrl;
            }
            else
            {
                clearForm();
            }
        }
        private void clearForm()
        {
            titleText.Text = string.Empty;
            userText.Text = string.Empty;
            usernameText.Text = string.Empty;
            couponText.Text = string.Empty;
            expirationText.Text = string.Empty;
            couponImage.Image = null;
        }
    }
}
