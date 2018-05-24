<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo4.aspx.cs" Inherits="System003.Diaobo4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label7" runat="server" Text="调拨已完成！" ForeColor="#00CC00" Font-Size="X-Large"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="库位名称"></asp:Label>
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
    <asp:Label ID="Label8" runat="server" Text="调拨人"></asp:Label>
    <br />
    <asp:Label ID="Label9" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button7" runat="server" Text="返回" OnClick="Button7_Click" class="button"/>
    </asp:Content>
