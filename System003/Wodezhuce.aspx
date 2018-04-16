<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Wodezhuce.aspx.cs" Inherits="System003.Wodezhuce" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label1" runat="server" Text="员工OA"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="ERP编号"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="所在部门"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>部门01</asp:ListItem>
        <asp:ListItem>部门02</asp:ListItem>
        <asp:ListItem>部门03</asp:ListItem>
        <asp:ListItem>部门04</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button8" runat="server" Text="注册" OnClick="Button8_Click" />
</asp:Content>
