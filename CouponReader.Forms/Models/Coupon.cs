using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponReaderDemo.Forms
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public Guid ExternalId { get; set; }
        public string User { get; set; }
        public string UserName { get; set; }
        public DateTime Expiration { get; set; }
        public string ImageUrl { get; set; }
        public string CouponText { get; set; }
        public bool Redeemed { get; set; }
    }
}
