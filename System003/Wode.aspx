<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Wode.aspx.cs" Inherits="System003.Wode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button15" runat="server" PostBackUrl="~/Xiugaimima.aspx" Text="修改密码" class="button"/>
    <asp:Button ID="Button10" runat="server" Text="设置" OnClick="Button10_Click" class="button"/>
    <asp:Button ID="Button11" runat="server" Text="关于" OnClick="Button11_Click" class="button"/>
    <asp:Button ID="Button12" runat="server" Text="意见反馈" OnClick="Button12_Click" class="button"/>
    <br />
    <p style="clear:both"></p>
    <div>
    <asp:Button ID="Button13" runat="server" Text="开启推送" Visible="False" class="button"/>
    <asp:Button ID="Button14" runat="server" Text="关闭推送" Visible="False" class="button"/>
    <asp:Label ID="Label4" runat="server" Text="版本号v0.0.2" Visible="False"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="意见反馈请发送至wmdfnysdyy@126.com" Visible="False"></asp:Label>
    </div>
</asp:Content>
