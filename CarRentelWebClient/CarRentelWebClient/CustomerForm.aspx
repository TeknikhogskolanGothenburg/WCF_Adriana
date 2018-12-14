<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="CarRentelWebClient.CustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <label for="First">FirstName</label>
                    <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <label for="Last">LastName</label>
                    <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="Tele">Telephone</label>
                    <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label for="Email">Email @..</label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
  
            <tr>
                <td>
                    <asp:Button ID="btnSaveCustomer" runat="server" Text="Send" OnClick="btnSaveCustomer_Click"  />
                </td>
            </tr>

        </table>
    </form>
