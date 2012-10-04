<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
            <asp:Label ID="Label1" runat="server" 
                Text="List of people in the database:&lt;br/&gt;"></asp:Label>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
