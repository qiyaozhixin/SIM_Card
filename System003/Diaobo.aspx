<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo.aspx.cs" Inherits="System003.Diaobo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Button ID="Button7" runat="server" Text="直销员工" OnClick="Button7_Click" />
    <asp:Button ID="Button8" runat="server" Text="地推网点" OnClick="Button8_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5">
        <Columns>
                <asp:BoundField DataField="员工OA" HeaderText="员工OA" ReadOnly="True" />
                <asp:BoundField DataField="ERP编号" HeaderText="ERP编号" />
                <asp:BoundField DataField="所在部门" HeaderText="所在部门" />
                <asp:TemplateField HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label3" runat="server" Text="注意：只能选择一名员工!"></asp:Label>
    <br />
    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="下一步" />
    </asp:Content>
