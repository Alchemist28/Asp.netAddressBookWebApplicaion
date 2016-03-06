<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="ManageState.aspx.cs" Inherits="ManageState" %>
    <%@ OutputCache CacheProfile="AppCache" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:Button ID="btnAdd" runat="server" Text="Add State" OnClick="btnAdd_Click" CausesValidation="false" />
    <br />
    <br />
    <asp:GridView ID="gvState" runat="server" AutoGenerateColumns="False" AllowPaging="True"
        OnPageIndexChanging="gvState_PageIndexChanging" CellPadding="4" ForeColor="#333333"
        GridLines="None" OnRowCommand="gvState_RowCommand" PageSize="5" Width="100%">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <%#Eval("CountryName") %>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="State" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <%#Eval("StateName") %>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IsActive" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Width="4%">
                <ItemTemplate>
                    <asp:CheckBox ID="chkIsActive" runat="server" Enabled="false" Checked=' <%#Eval("IsActive")%>' />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="4%"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="2%">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" CausesValidation="false" CommandName="DeleteState"
                        Text="Delete" CommandArgument='<%#Eval("PKStateId") %>'></asp:LinkButton>
                    <cc1:ConfirmButtonExtender ID="lnkDelete_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure? If you delete state all the addresses in this state get deleted"
                        Enabled="True" TargetControlID="lnkDelete">
                    </cc1:ConfirmButtonExtender>
                </ItemTemplate>
                <HeaderStyle Width="2%"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="2%">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="false" CommandName="EditState"
                        Text="Edit" CommandArgument='<%#Eval("PKStateId") %>'></asp:LinkButton>
                </ItemTemplate>
                <HeaderStyle Width="2%"></HeaderStyle>
            </asp:TemplateField>
        </Columns>
        <EmptyDataTemplate>
            <div style="border: 1px solid Black; text-align: center;">
                No records</div>
        </EmptyDataTemplate>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
   <%-- </div>
     </div>--%>
</asp:Content>
