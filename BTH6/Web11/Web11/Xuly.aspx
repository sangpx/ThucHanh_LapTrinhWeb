<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Web11.Xuly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        form{
            width: 300px;
            margin: 0 auto;
            margin-top: 30px;
            padding: 20px;
        }
        .table{
            border-collapse: collapse;
        }
        table, th, td {
          border: 1px solid black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Table CssClass="table" ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableHeaderCell>STT</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Họ tên</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Năm sinh</asp:TableHeaderCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
