<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Baobiao.aspx.cs" Inherits="System003.Baobiao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>销售报表</asp:ListItem>
        <asp:ListItem>余量报表</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button11" runat="server" Text="生成个人报表" OnClick="Button11_Click" class="button"/>
</asp:Content>
