using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    public static class Radker
    {
        // Truncate
        public static string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        // Text modifiers

        public static string RemoveDigits(string str)
        {
            return Regex.Replace(str, @"\d", "");
        }

        public static string RemoveLetters(string str)
        {
            return Regex.Replace(str, "[A-Za-z]", "");
        }

        public static string RemoveSpecial(string str)
        {
            return Regex.Replace(str, "[^0-9a-zA-Z]+", "");
        }

        // Generate stuff

        public static string PasswordGenerate(int length, int spec)
        {
            string password = System.Web.Security.Membership.GeneratePassword(length, spec);
            return password;
        }

        public static string PasswordGenerate_NoDigits(int length, int spec)
        {
            string password = RemoveDigits(PasswordGenerate(96, spec));
            while (password.Length < length) {
                password = RemoveDigits(PasswordGenerate(96, spec));
            }
            return Truncate(password, length);
        }

        public static string PasswordGenerate_NoLetters(int length, int spec)
        {
            string password = RemoveLetters(PasswordGenerate(96, spec));
            while (password.Length < length) {
                password = RemoveSpecial(PasswordGenerate(96, spec));
            }
            return Truncate(password, length);
        }

        public static string PasswordGenerate_NoSpecial(int length, int spec)
        {
            string password = RemoveSpecial(PasswordGenerate(96, spec));
            while (password.Length < length) {
                password = RemoveSpecial(PasswordGenerate(96, spec));
            }
            return Truncate(password, length);
        }

        public static string PasswordGenerate_NoDigitsSpecial(int length, int spec)
        {
            string password = Truncate(RemoveDigits(RemoveSpecial(PasswordGenerate(96, spec))), length);
            while (password.Length < length)
            {
                password = Truncate(RemoveDigits(RemoveSpecial(PasswordGenerate(96, spec))), length);
            }
            return password;
        }

        public static string PasswordGenerate_NoLettersSpecial(int length, int spec)
        {
            string password = RemoveLetters(RemoveSpecial(PasswordGenerate(96, spec)));
            while (password.Length < length)
            {
                password = RemoveLetters(RemoveSpecial(PasswordGenerate(96, spec)));
            }
            return Truncate(password, length);
        }
    }
}