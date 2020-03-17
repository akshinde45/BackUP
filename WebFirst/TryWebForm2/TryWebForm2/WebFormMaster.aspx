<%@ Page Title="" Language="C#" MasterPageFile="~/WebMaster.Master" AutoEventWireup="true" CodeBehind="WebFormMaster.aspx.cs" Inherits="TryWebForm2.WebFormMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <span>
    <asp:Label ID="Label1" runat="server" Text="First Number:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
    </span>
    <span>
        <asp:Label ID="Label2" runat="server" Text="Second Number:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
   </span>
           <br /><br />
    <span id="spanid" runat="server"></span>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1"  class="showhide" /> <br /><br />

  
    <asp:GridView ID="GridView1" runat="server" Width="240px">

    </asp:GridView>

   </asp:Content>
