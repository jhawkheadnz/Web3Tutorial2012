﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Main Page</title>
    <link rel="Stylesheet" href="css/StyleSheet.css" type="text/css" />
</head>
<body>
    <div id="nav"><p>Create | <a href="Edit.aspx">Edit</a></p></div>
    <div id="content">
    <form id="form1" runat="server">
            <!-- 
                Here is simple page where we will grab the data that we will access
                the logic layer and display the data that we want to output from the
                database.
            -->
<<<<<<< HEAD
            <p>First name: <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox></p>
            <p>Last name: <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox></p>
            <p><asp:Button ID="Button1" runat="server" Text="Add Person" onclick="Button1_Click" /></p>
            
=======
            First name: <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox><br />
            Last name: <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Add Person" 
                onclick="Button1_Click" />
            <br />
        </div>
>>>>>>> 0e2c3ba7a41805a840ade3fceb445ac76148d524
    </form>
    </div>
</body>
</html>
