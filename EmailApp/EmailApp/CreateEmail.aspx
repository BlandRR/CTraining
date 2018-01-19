<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmail.aspx.cs" Inherits="EmailApp.CreateEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action ="SendEmail.aspx" method ="post">
        <div>
            <Center>
            To : <input type ="text" name ="TO" />
                <br />
                <br />
            Subject : <input type ="text" name ="SUBJECT" />
                <br />
                <br />
                Body : <input type ="text" name ="BODY" />
                <br />
                <br />
           <input type ="submit" value ="Send Email" />
            </Center>
        </div>
    </form>
</body>
</html>
