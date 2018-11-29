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
    public partial class CouponHistoryControl : UserControl
    {
        public CouponHistoryControl()
        {
            InitializeComponent();
        }

        public void Init (CouponViewModel couponViewModel)
        {
            dataGridView1.DataSource = couponViewModel.CouponsHistoryList();
        }
    }
}
