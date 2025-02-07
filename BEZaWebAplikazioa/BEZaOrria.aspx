<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="BEZaOrria.aspx.vb" Inherits="BEZaWebAplikazioa.BEZaOrria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BEZa Orria</title>
</head>
<body>
    <form id="form1" runat="server">
        <label for="txtTotala">Sartu fakturaren totala:</label>
        <asp:TextBox ID="txtTotala" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtTotala" EnableClientScript="true"></asp:RequiredFieldValidator>
        <br />

        <label for="txtMota">Sartu BEZ mota (%21, %10, %5):</label>
         <asp:TextBox ID="txtMota" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtMota" EnableClientScript="true"></asp:RequiredFieldValidator><asp:CustomValidator runat="server" ErrorMessage="CustomValidator" ControlToValidate="txtMota" EnableClientScript="true" OnServerValidate="ValidateMota"></asp:CustomValidator>
        <br />

        <asp:Button ID="btnKalkulatu" runat="server" Text="Kalkulatu" OnClick="btnKalkulatu_Click" />
        <br /><br />

        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
