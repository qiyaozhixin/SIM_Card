<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Chaxun.aspx.cs" Inherits="System003.Chaxun1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <%--<asp:Label ID="Label3" runat="server" Text="请输入ICCID"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />--%>
    <asp:Button ID="Button9" runat="server" Text="调拨查询" OnClick="Button9_Click" PostBackUrl="~/Chaxun1_2.aspx" />
    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="销售查询" PostBackUrl="~/Chaxun1_3.aspx" />
</asp:Content>
