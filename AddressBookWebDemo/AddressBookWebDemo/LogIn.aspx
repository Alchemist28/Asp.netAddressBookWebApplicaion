<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 110px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true"
            ShowSummary="false" DisplayMode="BulletList" Style="margin-bottom: 56px" Width="180px" />
        <fieldset>
            <legend>Log In</legend>
            <table>
                <tr>
                    <td class="style1">
                        <label>
                            User Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" MaxLength="50" Style="margin-left: 0px"
                            Width="168px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmailId" runat="server" ControlToValidate="txtUserName"
                            EnableClientScript="true" SetFocusOnError="true" ErrorMessage="Please enter username"
                            Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        <label>
                            Password</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" MaxLength="50" Style="margin-left: 0px"
                            Width="168px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvtxtPassword" runat="server" ControlToValidate="txtPassword"
                            EnableClientScript="true" SetFocusOnError="true" ErrorMessage="Please enter password"
                            Text="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:CheckBox ID="chkRememberMe" runat="server" Text="Remember Me" />
                    </td>
                </tr>
                  <tr>
                    <td colspan="2">
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" PostBackUrl="~/Registration.aspx"
                            ForeColor="Black">Click here to Register</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" runat="server" Text="Log In" 
                            OnClick="btnLogin_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Clear" CausesValidation="false"
                            OnClick="btnCancel_Click" />
                    </td>
                </tr>
              
            </table>
        </fieldset>
    </div>
</asp:Content>
