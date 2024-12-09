<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestDatabase.aspx.cs" Inherits="TestDatabase" %>

<!DOCTYPE html>
<html>
<head>
    <title>Test Database Connection</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnTestConnection" runat="server" Text="Test Connection" OnClick="btnTestConnection_Click" />
            <br /><br />

            <!-- This is where gvTestResults is declared -->
            <asp:GridView ID="gvTestResults" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>
