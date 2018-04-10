<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo3.aspx.cs" Inherits="System003.Diaobo3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label5" runat="server" Text="请核对调拨信息!" Font-Size="X-Large" ForeColor="#CC0000"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="库位名称"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="ICCID"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button7" runat="server" Text="确定" OnClick="Button7_Click" />
    </asp:Content>
