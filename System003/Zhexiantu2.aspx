<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Zhexiantu2.aspx.cs" Inherits="System003.Zhexiantu2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Image ID="Image1"  src="Zhexiantu.aspx" runat="server" Height="350px" Width="750px" />
    <br />
    <asp:Button ID="Button13" runat="server" PostBackUrl="~/Baobiao3.aspx" Text="返回" class="button"/>
</asp:Content>
