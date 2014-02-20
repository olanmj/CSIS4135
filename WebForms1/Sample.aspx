<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sample.aspx.cs" Inherits="WebForms1.Sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <asp:label runat="server" text="Label">Miles: </asp:label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        <br />
        
    <asp:Label ID="Label1" runat="server" Text="Label">Gallons of gas:</asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Label">Miles per gallon:</asp:Label>
    </div>
    </form>
</body>
</html>
