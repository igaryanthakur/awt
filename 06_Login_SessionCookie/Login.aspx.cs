using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;

namespace LoginApp
{
    public partial class Login : Page
    {
        // Update with your SQL Server connection string
        private string connStr = System.Configuration.ConfigurationManager
                                      .ConnectionStrings["DefaultConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If already logged in via session, redirect to dashboard
            if (!IsPostBack && Session["Username"] != null)
                Response.Redirect("Dashboard.aspx");

            // If "Remember me" cookie exists, pre-fill username
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["RememberedUser"];
                if (cookie != null)
                    txtUsername.Text = cookie["Username"] ?? "";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateUser(username, password))
            {
                // Start session on successful login
                Session["Username"]  = username;
                Session["LoginTime"] = DateTime.Now.ToString("dd-MMM-yyyy HH:mm");

                // Store in cookie if "Remember me" checked
                if (chkRemember.Checked)
                {
                    HttpCookie cookie = new HttpCookie("RememberedUser");
                    cookie["Username"] = username;
                    cookie.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    // Remove any existing remember cookie
                    HttpCookie cookie = new HttpCookie("RememberedUser");
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Dashboard.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password. Please try again.";
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Use parameterized query to prevent SQL injection
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @u AND Password = @p";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password); // In production: use hashed passwords
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
