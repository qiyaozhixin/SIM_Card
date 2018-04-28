<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Guanli.aspx.cs" Inherits="System003.Guanli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button13" runat="server" Text="修改员工表" />
    <asp:Button ID="Button14" runat="server" Text="修改经理表" />
    <asp:Button ID="Button15" runat="server" Text="修改电话卡表" />
    <asp:Button ID="Button16" runat="server" Text="修改调拨表" />
    <asp:Button ID="Button17" runat="server" Text="修改销售表" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
