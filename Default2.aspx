<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Donate</h2>
    <table>
        <tr>
            <td>Enter Donation Amount:</td>
            <td><asp:TextBox ID="txtDonation" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="rfvDonation" runat="server" ErrorMessage="Must Enter a Donation Amount." ControlToValidate="txtDonation"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            <td><asp:Label ID="lblError" runat="server" Text=""></asp:Label></td>
            <td></td>
        </tr>
        <tr>
            <td><a href="Default3.aspx">Back</a></td>
            <td></td>
            <td></td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>
