<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarForm.aspx.cs" Inherits="CarRentelWebClient.CarForm" %>

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
                    <b>Id</b>
                </td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>RegNr</b>
                </td>
                <td>
                    <asp:TextBox ID="txtRegNo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Brand</b>
                </td>
                <td>
                    <asp:TextBox ID="txtBrand" runat="server"></asp:TextBox>
                </td>
            </tr>
                <td>
                    <b>Mark</b>
                </td>
                <td>
                    <asp:TextBox ID="txtMark" runat="server"></asp:TextBox>
                </td>
            
            <tr>
                <td>
                    <b>Year</b>
                </td>
                
                <td>
                    <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Returned</b>
                </td>
                <td>
                    <asp:CheckBox ID="chkReturned" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGetCar" runat="server" Text="Get Car" OnClick="btnSaveCar_Click" />

                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Save Car" OnClick="Button1_Click" />
                </td>
            </tr>

           
        </table>
        <p>
            &nbsp;</p>
    </form>
          
        
        
        
        
    


    
</body>
</html>
