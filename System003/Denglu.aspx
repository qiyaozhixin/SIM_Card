<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Denglu.aspx.cs" Inherits="System003.Denglu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/Default.aspx">
    </asp:Login>
</asp:Content>
