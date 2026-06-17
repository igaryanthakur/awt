using System;
using System.Web.Services;

namespace XMLWebService
{
    /// <summary>
    /// XML Web Service to check palindrome and calculate string operations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class PalindromeService : WebService
    {
        /// <summary>
        /// Checks if the input string is a palindrome
        /// </summary>
        [WebMethod(Description = "Returns true if the string is a palindrome")]
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Remove spaces and convert to lowercase for comparison
            string cleaned = input.Replace(" ", "").ToLower();
            string reversed = "";
            for (int i = cleaned.Length - 1; i >= 0; i--)
                reversed += cleaned[i];

            return cleaned == reversed;
        }

        /// <summary>
        /// Returns the reverse of a string
        /// </summary>
        [WebMethod(Description = "Returns the reverse of the input string")]
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Returns length of the string
        /// </summary>
        [WebMethod]
        public int StringLength(string input)
        {
            return input == null ? 0 : input.Length;
        }
    }
}
