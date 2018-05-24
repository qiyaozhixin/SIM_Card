<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Kaika3.aspx.cs" Inherits="System003.Kaika3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label4" runat="server" Font-Size="X-Large" ForeColor="#00CC00" Text="销售完成！"></asp:Label>
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
    <asp:Label ID="Label13" runat="server" Text="销售时间"></asp:Label>
    <br />
    <asp:Label ID="Label14" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button10" runat="server" Text="返回" PostBackUrl="~/Kaika.aspx" class="button"/>
</asp:Content>
