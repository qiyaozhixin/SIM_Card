﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo.aspx.cs" Inherits="System003.Diaobo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button7" runat="server" Text="直销员工" OnClick="Button7_Click" />
    <asp:Button ID="Button8" runat="server" Text="地推网点" OnClick="Button8_Click" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" PostBackUrl="~/Diaobo2.aspx" Text="下一步" />
</asp:Content>
