<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Kaika.aspx.cs" Inherits="System003.Kaika" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
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
                <asp:TemplateField HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label5" runat="server" Text="身份证号" Width="100px"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="套餐类型" Width="100px"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>20</asp:ListItem>
        <asp:ListItem>30</asp:ListItem>
        <asp:ListItem>50</asp:ListItem>
        <asp:ListItem>100</asp:ListItem>
        <asp:ListItem>200</asp:ListItem>
        <asp:ListItem>500</asp:ListItem>
        <asp:ListItem>888</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Button ID="Button10" runat="server" Text="确定" OnClick="Button10_Click" class="button"/>
</asp:Content>
