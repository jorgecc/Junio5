<%@ Page Language="C#" EnableViewState="true"  AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication33.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Id:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Nombre:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Poblacion:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:GridView ID="GridView1" runat="server" ViewStateMode="Enabled">
            </asp:GridView>
        </div>
    </form>
  
</body>
</html>
