
<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="ManageAddress.aspx.cs" Inherits="Admin_ManageAddress" %>
    <%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
<div style="min-height: 75px;">
        &nbsp;&nbsp;&nbsp;
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td class="tdLabel">
                    Country:&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="tdContent">
                    <asp:DropDownList ID="ddlCountry" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
               
                <td class="tdLabel">
                 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 
                    State:&nbsp;&nbsp;&nbsp;
                </td>
                <td class="tdContent">
                    <asp:DropDownList ID="ddlState" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="tdLabel">
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    IsActive:
                </td>
                <td class="tdContent">
                   
                    <asp:DropDownList ID="ddlIsActive" runat="server">
                        <asp:ListItem Text="Active" Value="1"></asp:ListItem>
                        <asp:ListItem Text="InActive" Value="0"></asp:ListItem>
                      
                    </asp:DropDownList>
                </td>
                <td>
                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
                    <asp:Button ID="btnSearch" Text="Search" runat="server" OnClick="btnSearch_Click" />
                &nbsp;</td>
            </tr>
        </table>
    </div>
    <div id="divgrid" runat="server">
        <asp:GridView ID="gvAddressBook" runat="server" GridLines="None" AutoGenerateColumns="False"
            CellPadding="4" ForeColor="#333333" AllowPaging="True" PageSize="5" OnPageIndexChanging="gvCountry_PageIndexChanging"
            Width="100%" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="First Name" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("FirstName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EmailId" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("EmailId")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PhoneNo" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("PhoneNO")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Street" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("Street") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("City") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("StateName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#Eval("CountryName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="IsActive" HeaderStyle-HorizontalAlign="Left" HeaderStyle-Width="2%">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkIsActive" runat="server" Enabled="false" Checked=' <%#Eval("IsActive")%>' />
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Left" Width="2%"></HeaderStyle>
                </asp:TemplateField>
           <%--     <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkSelect" runat="server" CausesValidation="false" CommandName="SelectAddress"
                            Text="Select" CommandArgument='<%#Eval("PKAddressId") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>--%>
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
    </div>
   <%-- <div id="divAdd" runat="server">
        <fieldset>
            <table>
                <tr>
                    <td>
                        <label>
                            First Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" Enabled="false" Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <label>
                            Last Name</label>
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <label>
                            Email Id</label>
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailId" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <label>
                            Phone Number</label>
                        <br />
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhoneNumber" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Address1</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress1" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Address2</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress2" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <label>
                            Country
                        </label>
                    </td>
                    <td class="style1">
                        <asp:DropDownList ID="ddlCountry" runat="server" Height="25px" AppendDataBoundItems="true"
                            Width="172px" AutoPostBack="true" Enabled="false">
                            <asp:ListItem Value="-1" Selected="True">Select Country</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <label>
                            State
                        </label>
                    </td>
                    <td class="style1">
                        <asp:DropDownList ID="ddlState" runat="server" Height="25px" AppendDataBoundItems="true"
                            Enabled="false" Width="172px" AutoPostBack="true">
                            <asp:ListItem Value="-1" Selected="True">Select State</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            City</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>
                            Street</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtStreet" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                </tr>
                <tr>
                    <td>
                        <label>
                            ZipCode</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtZipCode" runat="server" Enabled="false" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <label>
                            IsActive</label>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkIsActive" runat="server" Enabled="false" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnOK" runat="server" Text="Ok" OnClick="btnOK_Click" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>--%>
</asp:Content>

