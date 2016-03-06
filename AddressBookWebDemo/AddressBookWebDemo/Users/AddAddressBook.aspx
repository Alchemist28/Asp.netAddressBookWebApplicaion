<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMasterPage.master" AutoEventWireup="true"
    CodeFile="AddAddressbook.aspx.cs" Inherits="AddAddressbook" %>
<%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"
        ShowSummary="false" DisplayMode="BulletList" Style="margin-bottom: 56px" Width="180px" />
    <fieldset>
        <legend>
            <asp:Label ID="lblName" runat="server" /></legend>
        <table>
            <tr>
                <td>
                    <label>
                        First Name</label>
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server" MaxLength="50" Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter first name'
                        Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Last Name</label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        EmailId</label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtEmailId" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ControlToValidate="txtEmailId"
                        EnableClientScript="true" SetFocusOnError="true" Text="*" ErrorMessage='Please enter e-mail id'></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmailId" runat="server" ControlToValidate="txtEmailId"
                        ErrorMessage="Enter valid e-mail id ex:info@deccansoft.com"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        Display="Static" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Phone Number</label>
                    <br />
                </td>
                <td>
                    <asp:TextBox ID="txtPhoneNumber" runat="server" MaxLength="14" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ControlToValidate="txtPhoneNumber"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter phone number'
                        Text="*"></asp:RequiredFieldValidator>
                  <asp:RegularExpressionValidator ID="revPhoneNo" runat="server" ValidationExpression="^((\+){0,1}91(\s){0,1}(\-){0,1}(\s){0,1})[7-9][0-9]{9}$"
                            ControlToValidate="txtPhoneNumber" ErrorMessage="Please provide valid phoneno like +919849690577"
                             Display="Static"></asp:RegularExpressionValidator>

                 
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Address1</label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress1" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAddress1" runat="server" ControlToValidate="txtAddress1"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter Address1'
                        Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Address2</label>
                </td>
                <td>
                    <asp:TextBox ID="TxtAddress2" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Country
                    </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCountry" runat="server" Height="25px" AppendDataBoundItems="true"
                        Width="172px" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                        <asp:ListItem Value="-1" Selected="True">Select Country</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvCountryDropDownList" runat="server" ControlToValidate="ddlCountry"
                        InitialValue="-1" ErrorMessage='Please select country ' Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>

                    <label>
                        State
                    </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server" AppendDataBoundItems="true" Width="172px"
                        AutoPostBack="true">
                        <asp:ListItem Value="-1" Selected="True">Select State</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvStateDropDownList" runat="server" ControlToValidate="ddlState"
                        InitialValue="-1" ErrorMessage='Please select state' Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        City</label>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter city'
                        Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Street</label>
                </td>
                <td>
                    <asp:TextBox ID="txtStreet" runat="server" MaxLength="50" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvStreet" runat="server" ControlToValidate="txtStreet"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter street'
                        Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        ZipCode</label>
                </td>
                <td>
                    <asp:TextBox ID="txtZipCode" runat="server" MaxLength="9" Style="margin-left: 0px"
                        Width="168px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode"
                        EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter zipcode'
                        Text="*"></asp:RequiredFieldValidator>
                       
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        IsActive</label>
                </td>
                <td>
                    <asp:CheckBox ID="chkIsActive" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false"
                        OnClick="btnCancel_Click" />
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>

