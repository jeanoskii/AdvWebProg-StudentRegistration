<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentRegistration_Ermitano_Jeano._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Register - Student Registration System</title>
    <link rel="stylesheet" href="css/bootstrap.css" />
    <script src="js/bootstrap.js" type="text/javascript"></script>
</head>
<body>
    <h1>Student Registration System</h1>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblStudentID" runat="server" Text="Student ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMiddleName" runat="server" Text="Middle Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtMiddleName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label>
        <br />
        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblYear" runat="server" Text="Year"></asp:Label>
        <br />
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSection" runat="server" Text="Section"></asp:Label>
        <br />
        <asp:TextBox ID="txtSection" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
