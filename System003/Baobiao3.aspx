﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Baobiao3.aspx.cs" Inherits="System003.Baobiao2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
        <asp:ListItem>员工直销</asp:ListItem>
        <asp:ListItem>地推网点</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>销售报表</asp:ListItem>
        <asp:ListItem>余量报表</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="Label3" runat="server" Text="OA"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button9" runat="server" Text="生成报表" OnClick="Button9_Click" />
</asp:Content>