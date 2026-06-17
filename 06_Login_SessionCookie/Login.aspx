<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginApp.Login" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <style>
        body { font-family: Arial, sans-serif; background: #e8eaf6; }
        .login-box { width: 380px; margin: 100px auto; background: #fff;
                     padding: 35px; border-radius: 10px; box-shadow: 0 4px 15px rgba(0,0,0,0.15); }
        h2 { text-align: center; color: #3949ab; margin-bottom: 25px; }
        .form-group { margin: 14px 0; }
        .form-group label { display: block; font-weight: bold; margin-bottom: 5px; color: #444; }
        .form-group input { width: 92%; padding: 10px; border: 1px solid #ccc;
                            border-radius: 5px; font-size: 14px; }
        .btn-login { width: 100%; padding: 12px; background: #3949ab; color: white;
                     border: none; border-radius: 5px; font-size: 16px; cursor: pointer; margin-top: 10px; }
        .btn-login:hover { background: #303f9f; }
        .error { color: red; font-size: 13px; text-align: center; margin-top: 10px; }
        .remember { font-size: 13px; color: #555; margin-top: 8px; }
        .register-link { text-align: center; margin-top: 15px; font-size: 13px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h2>User Login</h2>

            <div class="form-group">
                <label>Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter username" />
                <asp:RequiredFieldValidator ID="rfvUser" runat="server"
                    ControlToValidate="txtUsername" ErrorMessage="Username required"
                    Display="Dynamic" ForeColor="Red" Font-Size="12px" />
            </div>

            <div class="form-group">
                <label>Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"
                             placeholder="Enter password" />
                <asp:RequiredFieldValidator ID="rfvPass" runat="server"
                    ControlToValidate="txtPassword" ErrorMessage="Password required"
                    Display="Dynamic" ForeColor="Red" Font-Size="12px" />
            </div>

            <div class="remember">
                <asp:CheckBox ID="chkRemember" runat="server" Text=" Remember me (save in Cookie)" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Login"
                        CssClass="btn-login" OnClick="btnLogin_Click" />

            <asp:Label ID="lblMessage" runat="server" CssClass="error" />

            <div class="register-link">
                Don't have an account?
                <asp:HyperLink NavigateUrl="Register.aspx" runat="server" Text="Register here" />
            </div>
        </div>
    </form>
</body>
</html>
