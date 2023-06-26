using System.Linq;
using System.Web;

namespace Southport.Messaging.Phone.Core.Shared
{
    public static class PhoneHelper
    {
        public static string NormalizePhoneNumber(string phoneNumber)
        {
            var startWithPlus = phoneNumber.StartsWith("+");
            if (startWithPlus)
            {
                return phoneNumber;
            }
            
            if (phoneNumber.StartsWith("1") == false)
            {
                return $"+1{phoneNumber}";
                
            }

            return $"+{phoneNumber}";
        }

     
    }
}
