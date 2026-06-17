# Login with DB + Session/Cookie

**Exam question:** Design ASP.NET Login application. Check username and password from SQL Server. On Successful Login, start a session. Store credentials in Cookies.

## Pages
- `Login.aspx` — login form with validation + Remember Me checkbox
- `Dashboard.aspx` — protected page showing session info, redirects if not logged in

## SQL Setup
Run `CreateDB.sql` in SSMS to create the `LoginDB` database and `Users` table with test data.

## Flow
```
User fills Login.aspx
  → ValidateUser() queries SQL Server with parameterized query
  → If valid: Session["Username"] = username
              If Remember Me: Cookie["RememberedUser"] stored for 30 days
  → Redirect to Dashboard.aspx
Dashboard.aspx checks Session["Username"]
  → If null: redirect back to Login.aspx
btnLogout: Session.Abandon() + expire cookie → redirect to Login
```

## Connection string
Update `Web.config` with your SQL Server instance name and database.
