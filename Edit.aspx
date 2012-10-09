<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link rel="Stylesheet" href="css/StyleSheet.css" type="text/css" />
</head>
<body>
    <div id="nav"><p><a href="Default.aspx">Create</a> | Edit</p></div>
    <div id="content">
        <form id="form1" runat="server">
                <!-- 
                    listing all the people in the database with options to edit and 
                    delete people from the database.
                -->

                <asp:Label ID="lblUsers" runat="server" Text="Label"></asp:Label>
        </form>
    </div>
</body>
</html>
