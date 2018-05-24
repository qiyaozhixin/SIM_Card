<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Chaxun2.aspx.cs" Inherits="System003.Chaxun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5" CssClass="GridViewStyle" AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging">   
        <FooterStyle CssClass="GridViewFooterStyle"/>
        <RowStyle CssClass="GridViewRowStyle"/>   
        <SelectedRowStyle CssClass="GridViewSelectedRowStyle"/>
        <PagerStyle CssClass="GridViewPagerStyle"/>
        <AlternatingRowStyle CssClass="GridViewAlternatingRowStyle"/>
        <HeaderStyle CssClass="GridViewHeaderStyle"/>
        <Columns>
                <asp:BoundField DataField="DBID" HeaderText="DBID" ReadOnly="True" />
                <asp:BoundField DataField="库位名称" HeaderText="库位名称" />
                <asp:BoundField DataField="调拨人" HeaderText="调拨人" />
                <asp:BoundField DataField="ICCID"  HeaderText="ICCID" />
                <asp:BoundField DataField="申请时间"  HeaderText="申请时间" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="返回" PostBackUrl="~/Chaxun.aspx" class="button"/>
</asp:Content>
