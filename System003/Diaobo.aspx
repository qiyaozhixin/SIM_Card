<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo.aspx.cs" Inherits="System003.Diaobo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button7" runat="server" Text="直销员工" />
    <asp:Button ID="Button8" runat="server" Text="地推网点" />
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:CheckBoxField Text="Test" />
        </Columns>
    </asp:GridView>
</asp:Content>
