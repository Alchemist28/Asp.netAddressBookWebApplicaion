<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="AddState.aspx.cs" Inherits="AddState" %>
    <%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"
        DisplayMode="BulletList" ShowSummary="false" Style="margin-bottom: 56px; margin-left: 8px;" />
    <fieldset>
        <legend>
            <asp:Label ID="lblName" runat="server" /></legend>
        <table>
            <tr>
                <td>
                    <label>
                        Country
                    </label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCountry" runat="server" Height="25px" AppendDataBoundItems="true"
                        Width="170px" Style="margin-left: 0px">
                        <asp:ListItem Value="-1" Selected="True">Select Country Name</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvCountryDropDoqnList" runat="server" ControlToValidate="ddlCountry"
                        InitialValue="-1" ErrorMessage="Please select country name" Text="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        State
                    </label>
                </td>
                <td>
                    <asp:TextBox ID="txtStateName" runat="server" Style="margin-left: 1px" Width="164px"
                        MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvStateName" runat="server" ControlToValidate="txtStateName"
                        ErrorMessage='Please enter state name' EnableClientScript="true" SetFocusOnError="true"
                        Text="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revStateName" runat="server" ControlToValidate="txtStateName" ErrorMessage="please enter text only"
                           ValidationExpression="[A-Za-z]+" Display="Static"></asp:RegularExpressionValidator>

                     
 
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Is Active</label>
                </td>
                <td>
                    <asp:CheckBox ID="chkIsActive" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                   
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnUpdate_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"
                        CausesValidation="false" />
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
