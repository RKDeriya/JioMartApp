<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="JioMartApp.login" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

 
    <p>Provide Following Details</p>  
    <table class="auto-style1">  
        <tr>  
            <td class="auto-style2">Email</td>  
            <td>  
                <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2">Password</td>  
            <td>  
                <asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td class="auto-style2"> </td>  
            <td>  
                <asp:Button ID="userlogin" runat="server" Text="Login" OnClick="login_Click" />  
            </td>  
        </tr>  
    </table>  
    <br />  
    <asp:Label ID="errorlbl" runat="server"></asp:Label>  
    <br />  
    <asp:Label ID="Lab" runat="server"></asp:Label>  


</asp:Content>