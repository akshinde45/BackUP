<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyFirstWeb.aspx.cs" Inherits="MyFirstWeb.MyFirstWeb" %>

<asp:Content ID="my123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbo">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        </div>
 
        
</asp:Content>


