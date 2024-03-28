<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="ChatApplication.Display" %>
<%@ Import Namespace="System.Web" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Messages</title>
</head>
<body>
    <h1>Chat History</h1>
    <div>
        <asp:Literal ID="litMessages" runat="server"></asp:Literal>
    </div>
    <br>
    <a href="ChatPage.html">Back to Chat</a>
</body>
</html>
