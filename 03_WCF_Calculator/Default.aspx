<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WCFCalculator.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>WCF Calculator</title>
    <style>
        body { font-family: Arial, sans-serif; background: #f0f4f8; }
        .container { width: 520px; margin: 50px auto; background: #fff;
                     padding: 30px; border-radius: 10px; box-shadow: 0 2px 12px rgba(0,0,0,0.12); }
        h2 { color: #1a6b3a; text-align: center; }
        .row { display: flex; gap: 12px; margin: 10px 0; align-items: center; }
        .row label { width: 80px; font-weight: bold; color: #444; }
        input[type=text] { flex: 1; padding: 8px; font-size: 14px;
                            border: 1px solid #ccc; border-radius: 5px; }
        .btn-group { display: flex; flex-wrap: wrap; gap: 8px; margin: 15px 0; }
        .btn-group input { padding: 10px 18px; border: none; border-radius: 5px;
                           cursor: pointer; font-size: 14px; color: white; }
        .btn-add  { background: #28a745; }
        .btn-sub  { background: #dc3545; }
        .btn-mul  { background: #007bff; }
        .btn-div  { background: #fd7e14; }
        .btn-circ { background: #6f42c1; }
        .btn-tri  { background: #20c997; }
        .result { margin-top: 20px; padding: 15px; background: #e8f5e9;
                  border-left: 4px solid #28a745; border-radius: 5px;
                  font-size: 18px; font-weight: bold; color: #1a6b3a; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>WCF Calculator Service</h2>
            <p style="text-align:center;color:#888;font-size:13px;">Consuming WCF Service</p>

            <div class="row">
                <label>Number 1:</label>
                <asp:TextBox ID="txtNum1" runat="server" placeholder="e.g. 10" />
            </div>
            <div class="row">
                <label>Number 2:</label>
                <asp:TextBox ID="txtNum2" runat="server" placeholder="e.g. 5" />
            </div>

            <div class="btn-group">
                <asp:Button ID="btnAdd"      runat="server" Text="Add (+)"         CssClass="btn-add"  OnClick="btnAdd_Click" />
                <asp:Button ID="btnSubtract" runat="server" Text="Subtract (-)"    CssClass="btn-sub"  OnClick="btnSubtract_Click" />
                <asp:Button ID="btnMultiply" runat="server" Text="Multiply (×)"    CssClass="btn-mul"  OnClick="btnMultiply_Click" />
                <asp:Button ID="btnDivide"   runat="server" Text="Divide (÷)"      CssClass="btn-div"  OnClick="btnDivide_Click" />
                <asp:Button ID="btnCircle"   runat="server" Text="Area of Circle"  CssClass="btn-circ" OnClick="btnCircle_Click" />
                <asp:Button ID="btnTriangle" runat="server" Text="Area of Triangle" CssClass="btn-tri" OnClick="btnTriangle_Click" />
            </div>

            <asp:Label ID="lblResult" runat="server" CssClass="result" Visible="false" />
            <asp:Label ID="lblError"  runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
