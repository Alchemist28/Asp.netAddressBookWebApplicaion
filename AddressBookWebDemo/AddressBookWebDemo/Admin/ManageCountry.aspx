<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master"
    AutoEventWireup="true" CodeFile="ManageCountry.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="head">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Button ID="btnAdd" runat="server" Text="Add Country" OnClick="btnAdd_Click"
        CausesValidation="false" />
    <br />
    <br />
    <asp:GridView ID="gvCountry" runat="server" GridLines="None" AutoGenerateColumns="False"
        CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvCountry_PageIndexChanging"
        Width="100%" OnRowCommand="gvCountry_RowCommand">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <%#Eval("CountryName") %>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ZipCode Start" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <%#Eval("ZipCodeStart")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ZipCode End" HeaderStyle-HorizontalAlign="Left">
                <ItemTemplate>
                    <%#Eval("ZipCodeEnd")%>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                <ItemStyle HorizontalAlign="Left"></ItemStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="IsActive" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Width="2%">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" Enabled="false" Checked=' <%#Eval("IsActive")%>' />
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" Width="2%"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="2%">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDelete" runat="server" CausesValidation="false" CommandName="DeleteCountry"
                        Text="Delete" CommandArgument='<%#Eval("PKCountryId") %>'></asp:LinkButton>
                    <cc1:ConfirmButtonExtender ID="lnkDelete_ConfirmButtonExtender" runat="server" ConfirmText="Are you sure? If you delete all the states in this country will get deleted"
                        Enabled="True" TargetControlID="lnkDelete">
                    </cc1:ConfirmButtonExtender>
                </ItemTemplate>
                <HeaderStyle Width="2%"></HeaderStyle>
            </asp:TemplateField>
            <asp:TemplateField HeaderStyle-Width="4%">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEdit" runat="server" CausesValidation="false" CommandName="EditCountry"
                        Text="Edit" CommandArgument='<%#Eval("PKCountryId") %>'></asp:LinkButton>
                </ItemTemplate>
                <HeaderStyle Width="4%"></HeaderStyle>
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
</asp:Content>
