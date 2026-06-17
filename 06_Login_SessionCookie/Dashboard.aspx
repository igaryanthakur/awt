<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="LoginApp.Dashboard" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Dashboard</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f5f5f5; }
        .dash { width: 500px; margin: 80px auto; background: #fff;
                padding: 30px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
        h2 { color: #3949ab; }
        .info-table td { padding: 8px 12px; font-size: 15px; border-bottom: 1px solid #eee; }
        .info-table td:first-child { font-weight: bold; color: #555; width: 40%; }
        .btn-logout { background: #dc3545; color: white; padding: 10px 25px;
                      border: none; border-radius: 5px; cursor: pointer; font-size: 14px; margin-top: 20px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dash">
            <h2>Welcome, <asp:Label ID="lblUsername" runat="server" />!</h2>
            <p style="color:#666;">You have successfully logged in.</p>

            <table class="info-table">
                <tr><td>Username</td>   <td><asp:Label ID="lblUser"  runat="server" /></td></tr>
                <tr><td>Login Time</td> <td><asp:Label ID="lblTime"  runat="server" /></td></tr>
                <tr><td>Session ID</td> <td><asp:Label ID="lblSessId" runat="server" /></td></tr>
                <tr><td>Cookie Set</td> <td><asp:Label ID="lblCookie" runat="server" /></td></tr>
            </table>

            <asp:Button ID="btnLogout" runat="server" Text="Logout"
                        CssClass="btn-logout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
