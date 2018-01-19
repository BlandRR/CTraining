<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EmailApp.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action ="CheckLogin.aspx" method ="post">
        <div>
                <asp:Label ID="Label1" runat="server" Text="" ForeColor ="Red"></asp:Label>
                <br />
                <br />
                <br />

            <Center>

                LOGIN
                 <br />
                <br />
            Username : <input type ="text" name ="Username" />
                <br />
                <br />
            Password : <input type ="password" name ="Password" />
                <br />
                <br />
           <input type ="submit" value ="login" />
            </Center>
            
        </div>


    </form>
</body>
</html>
