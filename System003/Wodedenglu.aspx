﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Wodedenglu.aspx.cs" Inherits="System003.Wodedenglu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>员工登录</asp:ListItem>
        <asp:ListItem>地推网点或部门经理登录</asp:ListItem>
        <asp:ListItem>总经理登录</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label1" runat="server" Text="OA"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button8" runat="server" Text="确认" OnClick="Button8_Click" />
    <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
    <br />
<asp:Label ID="Label4" runat="server" Text="如果还没有账号，请"></asp:Label>
<asp:Button ID="Button9" runat="server" PostBackUrl="~/Wodezhuce.aspx" Text="注册" />
</asp:Content>
