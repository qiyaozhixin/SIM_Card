<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Chaxun3.aspx.cs" Inherits="System003.Chaxun3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="返回" PostBackUrl="~/Chaxun.aspx" />
</asp:Content>
