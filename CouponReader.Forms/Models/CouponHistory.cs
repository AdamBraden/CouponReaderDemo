using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponReaderDemo.Forms
{
    public class CouponHistory
    {
        public DateTime Date { get; set; }
        public Coupon Coupon { get; set; }
    }

    //class purely for display purposes in a datagridview
    public class CouponsHistoryList
    {
        public string Date { get; set; }
        public string Code { get; set; }
        public string CouponText { get; set; }
        public string UserName { get; set; }
    }
}
