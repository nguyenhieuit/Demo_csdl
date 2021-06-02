<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="demo_csdl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .loaihang{
            margin-left:200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="loaihang">
            Danh sách các loại hàng: <asp:RadioButtonList ID="rdb_listSP" runat="server" OnSelectedIndexChanged="rdb_listSP_SelectedIndexChanged" AutoPostBack="true"></asp:RadioButtonList>
        </div>
    </form>
</body>
</html>
