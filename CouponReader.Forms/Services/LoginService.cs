using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Credentials.UI;

namespace CouponReaderDemo.Forms
{
    public class LoginService
    {
        public async Task<bool> SignInAsync()
        {
            await Task.Delay(500);
            return true;
        }

        // Add reference to Windows.winmd, typically c:\program files (x86)\windows kits\10\UnionMetadata\{version}
        // Add reference to System.Runtime.WindowsRuntime.dll, typically C:\Windows\Microsoft.NET\Framework\v4.0.30319
        public async Task<bool> WindowsHelloSignInAsync()
        {
            // Check the availability of Windows Hello authentication through User Consent Verifier.
            UserConsentVerifierAvailability consentAvailability = await UserConsentVerifier.CheckAvailabilityAsync();
            if (consentAvailability == UserConsentVerifierAvailability.Available)
            {
                // Request the user's consent using Windows Hello via biometric verification or a PIN.
                string message = "Please confirm your identity to login to this app";
                UserConsentVerificationResult consentResult = await UserConsentVerifier.RequestVerificationAsync(message);
                switch (consentResult)
                {
                    case UserConsentVerificationResult.Verified:
                        System.Diagnostics.Debug.WriteLine("User verified");
                        return true;
                }
            }
            return false;
        }
    }
}
