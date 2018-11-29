using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponReaderDemo.Forms
{
    public class LoginService
    {
        public async Task<bool> SignInAsync()
        {
            await Task.Delay(500);

            return true;
        }
    }
}
