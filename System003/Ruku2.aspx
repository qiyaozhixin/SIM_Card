<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Ruku2.aspx.cs" Inherits="System003.Ruku2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="确认选择" class="button"/>
    <br />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5" CssClass="GridViewStyle">
        <FooterStyle CssClass="GridViewFooterStyle"/>
        <RowStyle CssClass="GridViewRowStyle"/>   
        <SelectedRowStyle CssClass="GridViewSelectedRowStyle"/>
        <PagerStyle CssClass="GridViewPagerStyle"/>
        <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle"/>
        <HeaderStyle CssClass="GridViewHeaderStyle"/>
        <Columns>
                <asp:BoundField DataField="ICCID" HeaderText="ICCID" ReadOnly="True" />
                <asp:BoundField DataField="PUK码" HeaderText="PUK码" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="确认导入" class="button"/>
</asp:Content>
