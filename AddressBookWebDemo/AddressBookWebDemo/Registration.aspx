<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<%@ OutputCache CacheProfile="AppCache" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 117px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"
            ShowSummary="false" DisplayMode="BulletList" Style="margin-bottom: 56px" Width="180px" />
        <div>
            <fieldset>
                <legend>Registration</legend>
                <table>
                    <tr>
                        <td class="style1">
                            <label>
                                User Name</label>
                            <br />
                        </td>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server" MaxLength="50" Style="margin-left: 0px"
                                Width="168px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName"
                                EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter user name'
                                Text="*"></asp:RequiredFieldValidator>
                               <%-- <asp:RegularExpressionValidator ID="revUserName" runat="server"  ControlToValidate="txtUserName" ErrorMessage="User name must be minimum 6 characters maximum 15 characters starting character shouldbe alphabet Ex: Mohan123"
                                  ValidationExpression="[A-Za-z][A-Za-z0-9._]{5,14}" Display="Static"></asp:RegularExpressionValidator>--%>

                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
                            <label>
                                Password</label>
                            <br />
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword" runat="server" MaxLength="50" Style="margin-left: 0px"
                                Width="168px" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                                EnableClientScript="true" SetFocusOnError="true" ErrorMessage='Please enter password'
                                Text="*"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password should be of minimum of 6 characters" 
                                ValidationExpression=".{6}.*" Display="static" ></asp:RegularExpressionValidator>
                             
                        </td>
                    </tr>
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
                        <td class="style1">
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
                        <td class="style1">
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
                                ErrorMessage="Enter valid e-mail id Ex: info@deccansoft.com" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                Display="Dynamic" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style1">
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
                        <td colspan="2">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
                            <asp:Button ID="btnCancel" runat="server" Text="Clear" CausesValidation="false"
                                OnClick="btnCancel_Click" />
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </div>
</asp:Content>
