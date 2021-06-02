<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sp_datalist.aspx.cs" Inherits="demo_csdl.sp_datalist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" Width="274px">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/HinhSP/"+Eval("Hinh") %>' />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenSP") %>'></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Gia") %>'></asp:Label>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Eval("TenSP") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
