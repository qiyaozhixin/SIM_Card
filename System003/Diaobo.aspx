<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo.aspx.cs" Inherits="System003.Diaobo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button7" runat="server" Text="直销员工" OnClick="Button7_Click" />
    <asp:Button ID="Button8" runat="server" Text="地推网点" OnClick="Button8_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5">
        <Columns>
                <asp:BoundField DataField="OA" HeaderText="OA" ReadOnly="True" />
                <asp:BoundField DataField="ERP编号" HeaderText="ERP编号" />
                <asp:BoundField DataField="部门" HeaderText="部门" />
                <asp:TemplateField HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="下一步" />
    </asp:Content>
