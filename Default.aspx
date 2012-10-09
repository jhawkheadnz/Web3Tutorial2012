<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Main Page</title>
    <link rel="Stylesheet" href="css/StyleSheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- 
                Here is simple page where we will grab the data that we will access
                the logic layer and display the data that we want to output from the
                database.
            -->
            First name: <asp:TextBox ID="tbxFirstName" runat="server"></asp:TextBox><br />
            Last name: <asp:TextBox ID="tbxLastName" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Add Person" 
                onclick="Button1_Click" />
            <br />
            <br />
            <strong><asp:Label ID="Label1" runat="server" 
                Text="List of people in the database:&lt;br/&gt;"></asp:Label></strong>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
