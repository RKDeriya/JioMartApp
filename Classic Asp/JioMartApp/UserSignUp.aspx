<%@ Page Title="UserSignUp" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="JioMartApp.UserSignUp" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <h3> Please Provide Following Details to register</h3>

<asp:Label ID="lblUserFirstName" runat="server" Text="First Name"></asp:Label>
<asp:TextBox ID="txtUserFirstName" runat="server" TextMode="SingleLine"></asp:TextBox><br/>
<asp:Label ID="lblUserLastName" runat="server" Text="Last Name"></asp:Label>
<asp:TextBox ID="txtUserLastName" runat="server"></asp:TextBox><br />
<asp:Label ID="lblUserEmail" runat="server" Text="Email"></asp:Label>
<asp:TextBox ID="txtUserEmail" runat="server"></asp:TextBox><br />
<asp:Label ID="lblUserMobileNo" runat="server" Text="Mobile Number"></asp:Label>
<asp:TextBox ID="txtUserMobileNo" runat="server"></asp:TextBox><br />
<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
<asp:TextBox ID="txtPasssword" runat="server"></asp:TextBox><br />
<asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />

<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
<asp:Button ID="btnsignup" runat="server" Text="Sign Up" OnClick="Signup_Click" />
<%--<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btn_Login_Click" />--%>


</asp:Content>