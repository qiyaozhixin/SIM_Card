<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Chaxun3.aspx.cs" Inherits="System003.Chaxun3" %>
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
                <asp:BoundField DataField="XSID" HeaderText="XSID" ReadOnly="True" />
                <asp:BoundField DataField="ICCID" HeaderText="ICCID" />
                <asp:BoundField DataField="PUK码" HeaderText="PUK码" />
                <asp:BoundField DataField="套餐类型"  HeaderText="套餐类型" />
                <asp:BoundField DataField="销售者"  HeaderText="销售者" />
                <asp:BoundField DataField="销售时间"  HeaderText="销售时间" />
                <asp:BoundField DataField="身份证号"  HeaderText="身份证号" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="返回" PostBackUrl="~/Chaxun.aspx" class="button"/>
</asp:Content>
