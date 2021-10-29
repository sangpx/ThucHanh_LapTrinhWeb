<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="bai10.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bài 10</title>
    <style>
        #bai10{
            margin-left: 300px;
            margin-top: 70px;
            width: 400px;
            height: 150px;
            border: 1px black solid;
            padding: 20px;
        }

    </style>
</head>
<body>
    <form id="bai10" runat="server" action="#"  method="post" enctype="multipart/form-data">
        <div>
            <textarea  name="txtNoidung" id="txtNoidung" cols="50" rows="3"></textarea>
            <br />
            <br />
            <input type="file" name="txtFile" />
            <br />          
            <br />
            <input type="submit" value="submit"  />
        </div>
    </form>
</body>
</html>
