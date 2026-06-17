<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XMLWebService.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Palindrome Checker - Web Service Client</title>
    <style>
        body { font-family: Arial, sans-serif; background: #eef2ff; }
        .container { width: 500px; margin: 60px auto; background: #fff;
                     padding: 30px; border-radius: 10px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }
        h2 { color: #3c3c8a; text-align: center; }
        input[type=text] { width: 90%; padding: 10px; font-size: 15px;
                            border: 1px solid #ccc; border-radius: 5px; margin: 10px 0; }
        input[type=submit] { background: #3c3c8a; color: white; padding: 10px 30px;
                              border: none; border-radius: 5px; cursor: pointer; font-size: 15px; }
        .result { margin-top: 20px; padding: 15px; border-radius: 5px; font-size: 16px; font-weight: bold; }
        .palindrome { background: #d4edda; color: #155724; }
        .not-palindrome { background: #f8d7da; color: #721c24; }
        .info-row { margin-top: 10px; color: #555; font-size: 14px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Palindrome Checker</h2>
            <p style="text-align:center;color:#777;">Powered by XML Web Service</p>

            <asp:TextBox ID="txtInput" runat="server" placeholder="Enter a word or phrase..."
                         style="width:90%;padding:10px;font-size:15px;border:1px solid #ccc;border-radius:5px;margin:10px 0;" />
            <br />
            <asp:Button ID="btnCheck" runat="server" Text="Check Palindrome"
                        OnClick="btnCheck_Click"
                        style="background:#3c3c8a;color:white;padding:10px 30px;border:none;border-radius:5px;cursor:pointer;font-size:15px;" />

            <asp:Panel ID="pnlResult" runat="server" Visible="false">
                <asp:Label ID="lblResult" runat="server" CssClass="result" />
                <div class="info-row">
                    Reversed: <asp:Label ID="lblReversed" runat="server" />
                </div>
                <div class="info-row">
                    Length: <asp:Label ID="lblLength" runat="server" /> characters
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
