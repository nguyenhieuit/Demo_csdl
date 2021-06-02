<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="demo_csdl.sanpham" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .img_sp{
            width:100px;
        }
        .img_sp:hover{
            transform:scale(1.1);
            transition:1s;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Mặt hàng</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="76px">
                <Columns>
                    <asp:TemplateField HeaderText="Hình ảnh">
                        <ItemTemplate>
                            <asp:Image CssClass="img_sp" ID="Image1" ImageUrl='<%#"~/images/HinhSP/"+Eval("Hinh") %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="TenSP" HeaderText="Tên hàng" />
                    <asp:BoundField DataField="Gia" HeaderText="Giá" />
                    <asp:BoundField DataField="MoTa" HeaderText="Mô tả" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
