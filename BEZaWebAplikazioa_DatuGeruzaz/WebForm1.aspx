<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="BEZaWebAplikazioa_DatuGeruzaz.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Fakturak</title>
</head>
<body>
    <form id="form1" runat="server">
        <label for="txtKodea">Sartu fakturaren kodea (1 eta 4 artean):</label>
        <asp:TextBox ID="txtKodea" runat="server"></asp:TextBox><asp:RequiredFieldValidator runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtKodea" EnableClientScript="true"></asp:RequiredFieldValidator><asp:RangeValidator runat="server" ErrorMessage="RangeValidator" ControlToValidate="txtKodea" EnableClientScript="true" MinimumValue="1" MaximumValue="4" Type="Integer"></asp:RangeValidator>
        <br />

        <asp:Button ID="btnKalkulatu" runat="server" Text="Kalkulatu" OnClick="btnKalkulatu_Click" />
        <br /><br />

        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
