<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ECOM.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 283px">
    <form id="form1" runat="server">
        <p><h1>
            THIS IS AN ECOMMERCE WEB APP</h1>&nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="CUSTOER NAME:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="18px" style="margin-left: 12px; margin-top: 0px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 31px" Text="Submit" />
        
        
    </form>
</body>
</html>
