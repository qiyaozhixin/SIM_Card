<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Guanli2.aspx.cs" Inherits="System003.Guanli2" %>
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
                <asp:BoundField DataField="员工OA" HeaderText="员工OA" ReadOnly="True" />
                <asp:BoundField DataField="ERP编号" HeaderText="ERP编号" />
                <asp:BoundField DataField="所在部门" HeaderText="所在部门" />
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
