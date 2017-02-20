<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentLogin.aspx.cs" Inherits="StudentLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Sansita" rel="stylesheet">
    <title>Student Login</title>
</head>
<body style="background-image: url(http://i.imgur.com/bR0NSRv.jpg);
    background-repeat: repeat;>
    <form id="form1" runat="server">
    <div style="height: 200px; width: 300px; border: 2px solid; text-align:center; 	margin: 0 auto; padding-left: 0.25em 0.625em; padding-top: 0.25em 0.625em; padding-bottom: 0.25em 0.625em; border-radius: 30px; background-color: #808080; font-family: 'Sansita', sans-serif;">
        <br/><br/><br/>
        User ID
        <asp:TextBox ID=TextBox1 runat="server"></asp:TextBox>
        <br/><br/><br/><asp:Button ID=Button1 runat="server" Text="Login"  Height="50"  Width="100"/><br/>
                    <a href="index.htm">Back</a>
            </div>
    </form>
</body>
</html>
