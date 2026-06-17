using System;
using System.Web;
using System.Web.UI;

namespace StateManagement
{
    public partial class PageCounter : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize ViewState counter
                ViewState["VSCount"] = 0;

                // Initialize Session counter if not set
                if (Session["SessionCount"] == null)
                    Session["SessionCount"] = 0;

                // Initialize Application counter if not set
                if (Application["AppCount"] == null)
                    Application["AppCount"] = 0;

                // Read cookie counter
                HttpCookie cookie = Request.Cookies["CookieCount"];
                int cookieCount = 0;
                if (cookie != null)
                    int.TryParse(cookie.Value, out cookieCount);

                // Display current values on first load
                UpdateDisplay(cookieCount);
            }
        }

        protected void btnVisit_Click(object sender, EventArgs e)
        {
            // 1. ViewState — stored in hidden field on the page
            int vsCount = (int)(ViewState["VSCount"] ?? 0) + 1;
            ViewState["VSCount"] = vsCount;

            // 2. Session — stored on server, unique per user
            int sessionCount = (int)(Session["SessionCount"] ?? 0) + 1;
            Session["SessionCount"] = sessionCount;

            // 3. Cookie — stored in browser, expires in 7 days
            HttpCookie cookie = Request.Cookies["CookieCount"] ?? new HttpCookie("CookieCount", "0");
            int cookieCount = 0;
            int.TryParse(cookie.Value, out cookieCount);
            cookieCount++;
            cookie.Value = cookieCount.ToString();
            cookie.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(cookie);

            // 4. Application — server-side, shared across all users
            // Lock to prevent race conditions with concurrent users
            Application.Lock();
            int appCount = (int)(Application["AppCount"] ?? 0) + 1;
            Application["AppCount"] = appCount;
            Application.UnLock();

            UpdateDisplay(cookieCount);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all counters
            ViewState["VSCount"]    = 0;
            Session["SessionCount"] = 0;

            // Expire the cookie
            HttpCookie cookie = new HttpCookie("CookieCount", "0");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            // Reset application state
            Application.Lock();
            Application["AppCount"] = 0;
            Application.UnLock();

            UpdateDisplay(0);
        }

        private void UpdateDisplay(int cookieCount)
        {
            lblViewState.Text   = ((int)(ViewState["VSCount"]    ?? 0)).ToString();
            lblSession.Text     = ((int)(Session["SessionCount"] ?? 0)).ToString();
            lblCookie.Text      = cookieCount.ToString();
            lblApplication.Text = ((int)(Application["AppCount"] ?? 0)).ToString();
        }
    }
}
