<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryWebTwo.aspx.cs" Inherits="TryWebForm2.TryWebTwo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ItemType="System.String" SelectMethod="GetCity" runat="server">
               
                <ItemTemplate>
                     <ul>
                  <li>  
                      <%# Item %></li>
                         </ul>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
