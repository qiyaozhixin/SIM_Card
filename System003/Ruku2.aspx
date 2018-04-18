<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Ruku2.aspx.cs" Inherits="System003.Ruku2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="确认选择" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="确认导入" />
</asp:Content>
