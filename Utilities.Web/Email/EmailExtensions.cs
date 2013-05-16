using System.Text.RegularExpressions;
using Utilities.Core.Text;

namespace Utilities.Web.Email
{
    public static class EmailExtensions
    {
        public static bool IsValidEmail(this string email)
        {
            if (email.IsEmpty())
            {
                return false;
            }

            email = email.Trim();
            var result = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
            return result;
        }
    }
}
