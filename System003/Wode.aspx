<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Wode.aspx.cs" Inherits="System003.Wode" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button10" runat="server" Text="设置" OnClick="Button10_Click" />
    <asp:Button ID="Button11" runat="server" Text="关于" OnClick="Button11_Click" />
    <asp:Button ID="Button12" runat="server" Text="意见反馈" OnClick="Button12_Click" />
    <br />
    <asp:Button ID="Button13" runat="server" Text="开启推送" Visible="False" />
    <asp:Button ID="Button14" runat="server" Text="关闭推送" Visible="False" />
    <asp:Label ID="Label4" runat="server" Text="版本号v0.0.1" Visible="False"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="意见反馈请发送至wmdfnysdyy@126.com" Visible="False"></asp:Label>
</asp:Content>
