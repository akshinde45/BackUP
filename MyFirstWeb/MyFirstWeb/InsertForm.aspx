<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InsertForm.aspx.cs" Inherits="MyFirstWeb.InsertForm" %>

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button4_Click1(object sender, EventArgs e)
    {

    }
</script>


<asp:Content ID="my123" ContentPlaceHolderID="MainContent" runat="server">

        <br /><br />
<h1>Product Details</h1>
    <br /><asp:Label ID="Label1" runat="server" Text="Label">ID:</asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Label">Name:</asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Label">Category: </asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label4" runat="server" Text="Label">Price:</asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Search" />
    <br /><br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
    
</asp:Content>

