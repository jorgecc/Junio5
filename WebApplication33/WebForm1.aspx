<%@ Page Language="C#" EnableViewState="true"  AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication33.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" CssClass="btn btn-warning" />
            <br />
            <asp:GridView ID="GridView1" runat="server" ViewStateMode="Enabled" CssClass="table table-striped">
            </asp:GridView>
        </div>
    </form>
  
</body>
</html>
