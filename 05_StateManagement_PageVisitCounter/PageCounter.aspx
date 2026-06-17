<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCounter.aspx.cs" Inherits="StateManagement.PageCounter" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Page Visit Counter - State Management</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f0f0f0; }
        .container { width: 700px; margin: 40px auto; }
        h2 { color: #333; text-align: center; }
        .cards { display: flex; flex-wrap: wrap; gap: 20px; justify-content: center; margin: 20px 0; }
        .card { width: 280px; background: #fff; border-radius: 10px;
                padding: 20px; box-shadow: 0 2px 8px rgba(0,0,0,0.1); text-align: center; }
        .card h3 { margin: 0 0 8px; font-size: 15px; }
        .card .count { font-size: 48px; font-weight: bold; margin: 10px 0; }
        .card p { font-size: 12px; color: #888; margin: 0; }
        .card-viewstate { border-top: 4px solid #007bff; }
        .card-viewstate .count { color: #007bff; }
        .card-session   { border-top: 4px solid #28a745; }
        .card-session   .count { color: #28a745; }
        .card-cookie    { border-top: 4px solid #fd7e14; }
        .card-cookie    .count { color: #fd7e14; }
        .card-app       { border-top: 4px solid #6f42c1; }
        .card-app       .count { color: #6f42c1; }
        .btn-row { text-align: center; margin: 20px 0; }
        .btn { padding: 12px 30px; background: #333; color: white; border: none;
               border-radius: 6px; cursor: pointer; font-size: 15px; margin: 5px; }
        .btn-reset { background: #dc3545; }
        .note { background: #fff3cd; border: 1px solid #ffc107; padding: 12px;
                border-radius: 6px; font-size: 13px; margin-top: 20px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Page Visit Counter Demo</h2>
            <p style="text-align:center;color:#666;">Each button click = one page visit. Watch how each state type tracks it differently.</p>

            <div class="cards">
                <div class="card card-viewstate">
                    <h3>ViewState</h3>
                    <div class="count"><asp:Label ID="lblViewState" runat="server" Text="0" /></div>
                    <p>Client-side, this page only. Resets on new tab/browser.</p>
                </div>
                <div class="card card-session">
                    <h3>Session State</h3>
                    <div class="count"><asp:Label ID="lblSession" runat="server" Text="0" /></div>
                    <p>Server-side, per user. Resets when browser closes.</p>
                </div>
                <div class="card card-cookie">
                    <h3>Cookie</h3>
                    <div class="count"><asp:Label ID="lblCookie" runat="server" Text="0" /></div>
                    <p>Browser-side. Persists across browser restarts (7 days).</p>
                </div>
                <div class="card card-app">
                    <h3>Application State</h3>
                    <div class="count"><asp:Label ID="lblApplication" runat="server" Text="0" /></div>
                    <p>Server-side, ALL users. Resets only when app restarts.</p>
                </div>
            </div>

            <div class="btn-row">
                <asp:Button ID="btnVisit" runat="server" Text="Simulate Page Visit"
                            CssClass="btn" OnClick="btnVisit_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset All"
                            CssClass="btn btn-reset" OnClick="btnReset_Click" />
            </div>

            <div class="note">
                <strong>Key difference:</strong>
                ViewState resets when you open this page in a new tab.
                Session resets when you close the browser.
                Cookie persists for 7 days even after browser restart.
                Application State is shared — all visitors increment the same counter.
            </div>
        </div>
    </form>
</body>
</html>
