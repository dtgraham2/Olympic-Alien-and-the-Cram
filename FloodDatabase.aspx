<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FloodDatabase.aspx.cs" Inherits="FloodDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ListBox ID="ChoiceBox" runat="server" OnSelectedIndexChanged="ChoiceBox_SelectedIndexChanged">
            <asp:ListItem>Classroom</asp:ListItem>
            <asp:ListItem>Instructor</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:Button ID="FillDatabase" runat="server" OnClick="Button1_Click" Text="FillDatabase" />
        </p>
    </form>
</body>
</html>
