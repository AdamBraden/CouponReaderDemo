using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponReaderDemo.Forms
{
    public class CouponViewModel
    {
        private List<CouponsHistoryList> _c;
        public CouponViewModel(Coupon coupon)
        {
            var qry = from c in CouponsService.Instance.CouponHistory
                     where c.Coupon.Code == coupon.Code
                     select new CouponsHistoryList { Date = c.Date.ToLongDateString(), Code = c.Coupon.Code, CouponText = c.Coupon.CouponText, UserName = c.Coupon.UserName };
            _c = qry.ToList<CouponsHistoryList>();
        }

        public List<CouponsHistoryList> CouponsHistoryList()
        {
            return _c;
        }
    }
}
