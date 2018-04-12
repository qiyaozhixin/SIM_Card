<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Kaika2.aspx.cs" Inherits="System003.Kaika2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label4" runat="server" Font-Size="X-Large" ForeColor="Red" Text="请确认开卡信息！"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="ICCID"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="PUK码"></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label9" runat="server" Text="身份证号"></asp:Label>
    <br />
    <asp:Label ID="Label10" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label11" runat="server" Text="套餐类型"></asp:Label>
    <br />
    <asp:Label ID="Label12" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button10" runat="server" Text="确定" OnClick="Button10_Click" />
</asp:Content>
