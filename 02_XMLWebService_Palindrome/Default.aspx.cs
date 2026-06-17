using System;
using System.Web.UI;
// Add a Web Reference to PalindromeService.asmx in your project
// Right-click project -> Add -> Service Reference -> Advanced -> Add Web Reference
// URL: http://localhost:PORT/PalindromeService.asmx
// Namespace: PalindromeRef
// Then uncomment the lines below and remove the local call

namespace XMLWebService
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                lblResult.Text = "Please enter a word or phrase.";
                lblResult.CssClass = "result not-palindrome";
                pnlResult.Visible = true;
                return;
            }

            // ---- Consuming the Web Service ----
            // Option A: Via Web Reference proxy (uncomment after adding reference)
            // PalindromeRef.PalindromeService svc = new PalindromeRef.PalindromeService();
            // bool isPalin = svc.IsPalindrome(input);
            // string reversed = svc.ReverseString(input);
            // int length = svc.StringLength(input);

            // Option B: Direct call (same project for demo purposes)
            PalindromeService svc = new PalindromeService();
            bool isPalin = svc.IsPalindrome(input);
            string reversed = svc.ReverseString(input);
            int length = svc.StringLength(input);

            if (isPalin)
            {
                lblResult.Text = """ + input + "" IS a Palindrome! ✓";
                lblResult.CssClass = "result palindrome";
            }
            else
            {
                lblResult.Text = """ + input + "" is NOT a Palindrome ✗";
                lblResult.CssClass = "result not-palindrome";
            }

            lblReversed.Text = reversed;
            lblLength.Text = length.ToString();
            pnlResult.Visible = true;
        }
    }
}
