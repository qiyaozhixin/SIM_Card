<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Diaobo2.aspx.cs" Inherits="System003.Diaobo2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" PageSize="5">
        <Columns>
                <asp:BoundField DataField="ICCID" HeaderText="ICCID" ReadOnly="True" />
                <asp:BoundField DataField="当前库位" HeaderText="当前库位" />
                <asp:BoundField DataField="最近调拨" HeaderText="最近调拨" />
                <asp:TemplateField HeaderText="选择">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
        </Columns>
    </asp:GridView>
     <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="全选" />
     <asp:Button ID="Button12" runat="server" PostBackUrl="~/Diaobo.aspx" Text="上一步" />
    <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="下一步" />
</asp:Content>
