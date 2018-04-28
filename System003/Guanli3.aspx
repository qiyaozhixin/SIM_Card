<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Guanli3.aspx.cs" Inherits="System003.Guanli3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" 
            CellPadding="4" GridLines="Horizontal" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" 
            onrowupdating="GridView1_RowUpdating" PageSize="5" 
            style="font-size: small" AllowPaging="True" 
            onpageindexchanging="GridView1_PageIndexChanging">
            <RowStyle BackColor="White" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="客户经理OA" HeaderText="客户经理OA" ReadOnly="True" />
                <asp:BoundField DataField="网点名称" HeaderText="网点名称" />
                <asp:BoundField DataField="密码"  HeaderText="密码" />
                <asp:CommandField HeaderText="选择" ShowSelectButton="True" />
                <asp:CommandField ButtonType="Image" CancelImageUrl="~/Image/BtnCancel.gif" 
                    EditImageUrl="~/Image/BtnUpdate.gif" HeaderText="编辑" ShowEditButton="True" 
                    UpdateImageUrl="~/Image/BtnSave.gif" />
                <asp:TemplateField HeaderText="删除" ShowHeader="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandName="Delete" 
                            ImageUrl="~/Image/BtnDelete.gif" 
                            onclientclick="return confirm('确定删除吗？');" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
</asp:Content>
