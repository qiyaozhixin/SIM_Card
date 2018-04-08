<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo3.aspx.cs" Inherits="System003.Diaobo3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label2" runat="server" Text="员工OA"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="ICCID"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="调拨时间"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button7" runat="server" Text="确定" OnClick="Button7_Click" />
    </asp:Content>
