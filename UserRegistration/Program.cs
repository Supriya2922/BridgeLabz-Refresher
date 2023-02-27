using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace UserRegistration
{
    public class Program
    {
        public bool firstName(string name)
        {
            Regex pattern = new Regex(@"^([A-Z]{1}[a-z]{2,}$)+");
            Match match = pattern.Match(name);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public bool lastName(string name)
        {
            Regex pattern = new Regex(@"^([A-Z]{1}[a-z]{2,}$)+");
            Match match = pattern.Match(name);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public bool email(string email)
        {
            Regex pattern = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
            Match match = pattern.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public bool phone(string phone)
        {
            Regex pattern = new Regex(@"^[\d]{2}\s[1-9]{10}$");
            Match match = pattern.Match(phone);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public bool password(string password) {
            Regex pattern = new Regex(@"^(?=.*[0-9])(?=.*[A-Z])(?=[^@$!%*?&]*[@$!%*?&][^@$!%*?&]*$)([a-zA-Z0-9@$!%*?&]{8,})$");
            Match match = pattern.Match(password);
            if (match.Success)
            {
                return true;
            }
            return false;
        }


       public static void Main(string[] args)
        {
            
        }
    }
}