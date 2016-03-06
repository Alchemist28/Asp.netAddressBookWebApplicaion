<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true"
    CodeFile="AddCountry.aspx.cs" Inherits="AddCountry" %>
    <%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 120px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"
        DisplayMode="BulletList" ShowSummary="false" Style="margin-bottom: 56px" />
    <fieldset>
        <legend>
            <asp:Label ID="lblName" runat="server" /></legend>
        <table>
            <tr>
                <td class="style1">
                    <label>
                        Country</label>
                </td>
                <td>
                    <asp:TextBox ID="txtCountryName" runat="server" Style="margin-left: 1px" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCountryName" runat="server" ControlToValidate="txtCountryName"
                        ErrorMessage='Please enter countryname' EnableClientScript="true" SetFocusOnError="true"
                        Text="*">  
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCountryName" runat="server" ControlToValidate="txtCountryName" ErrorMessage="Please enter text only" 
                       ValidationExpression="[A-Za-z]+" Display="static" ></asp:RegularExpressionValidator>
 

                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        ZipCode Start</label>
                </td>
                <td>
                    <asp:TextBox ID="txtZipCodeStart" runat="server" MaxLength="9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZipCodeStart" runat="server" ControlToValidate="txtZipCodeStart"
                        ErrorMessage='Please enter zipcodestart' EnableClientScript="true" SetFocusOnError="true"
                        Text="*">  
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revZipCodeStart" runat="server" ControlToValidate="txtZipCodeStart" ValidationExpression="\d+" Display="Static"
                         ErrorMessage="Please enter numbers only"></asp:RegularExpressionValidator>
                 
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        ZipCode End</label>
                </td>
                <td>
                    <asp:TextBox ID="txtZipCodeEnd" runat="server" MaxLength="9"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZipCodeEnd" runat="server" ControlToValidate="txtZipCodeEnd"
                        ErrorMessage='Please enter zipcodeend' EnableClientScript="true" SetFocusOnError="true"
                        Text="*">  
                    </asp:RequiredFieldValidator>
                    <asp:CompareValidator ControlToCompare="txtZipCodeStart" ControlToValidate="txtZipCodeEnd"
                        Operator="GreaterThan" runat="server" ID="cv" ErrorMessage="Please enter valid zipcode range"
                        Display="Static"  />
                          <asp:RegularExpressionValidator ID="revZipCodeEnd" runat="server" ControlToValidate="txtZipCodeEnd" ValidationExpression="\d+" Display="Static"
                       EnableClientScript="true" ErrorMessage="Please enter numbers only" ></asp:RegularExpressionValidator>

                </td>
            </tr>
            <tr>
                <td >
                    <label>
                        Is Active</label>
                </td>
                <td>
                    <asp:CheckBox ID="chkIsActive" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"
                        CausesValidation="false" />
                </td>
            </tr>
        </table>
    </fieldset>
</asp:Content>
