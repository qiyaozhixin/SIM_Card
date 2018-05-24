<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Ruku.aspx.cs" Inherits="System003.Ruku" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label4" runat="server" Text="ICCID"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="PUK码"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button11" runat="server" Text="确定" OnClick="Button11_Click" class="button"/>
    <asp:Button ID="Button12" runat="server" Text="批量导入" PostBackUrl="~/Ruku2.aspx" class="button"/>
</asp:Content>
