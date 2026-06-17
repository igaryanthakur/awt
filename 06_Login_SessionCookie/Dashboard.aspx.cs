using System;
using System.Web;
using System.Web.UI;

namespace LoginApp
{
    public partial class Dashboard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Protect the page — redirect to login if not authenticated
            if (Session["Username"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                string username = Session["Username"].ToString();
                lblUsername.Text = username;
                lblUser.Text     = username;
                lblTime.Text     = Session["LoginTime"]?.ToString() ?? "-";
                lblSessId.Text   = Session.SessionID;

                // Check if remember-me cookie exists
                HttpCookie cookie = Request.Cookies["RememberedUser"];
                lblCookie.Text = (cookie != null)
                    ? "Yes (expires " + cookie.Expires.ToString("dd-MMM-yyyy") + ")"
                    : "No";
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Session.Clear();
            Session.Abandon();

            // Optionally clear the remember cookie too
            HttpCookie cookie = new HttpCookie("RememberedUser");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Response.Redirect("Login.aspx");
        }
    }
}
