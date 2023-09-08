<%@ Page Title="UserDashBoard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserDashBoard.aspx.cs" Inherits="JioMartApp.UserDashBoard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:gridview id="grid1" runat="server" autogeneratecolumns="false" cellpadding="4" forecolor="#333333" gridlines="none">
        <alternatingrowstyle backcolor="white" />
        <columns>
            <asp:boundfield datafield="productname" headertext="productname" sortexpression="productname" />
            <asp:boundfield datafield="productprice" headertext="productprice" sortexpression="productprice" />
        </columns>
        <editrowstyle backcolor="#2461bf" />
        <footerstyle backcolor="#507cd1" font-bold="true" forecolor="white" />
        <headerstyle backcolor="#507cd1" font-bold="true" forecolor="white" />
        <pagerstyle backcolor="#2461bf" forecolor="white" horizontalalign="center" />
        <rowstyle backcolor="#eff3fb" />
        <selectedrowstyle backcolor="#d1ddf1" font-bold="true" forecolor="#333333" />
        <sortedascendingcellstyle backcolor="#f5f7fb" />
        <sortedascendingheaderstyle backcolor="#6d95e1" />
        <sorteddescendingcellstyle backcolor="#e9ebef" />
        <sorteddescendingheaderstyle backcolor="#4870be" />
    </asp:gridview>
 
    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectwithJioMartDatabase %>" SelectCommand="SELECT ProductName, ProductPrice FROM JioMart.ProductDetails"></asp:SqlDataSource>--%>
    "
    <div>
        <asp:Repeater ID="Repeater1" runat="server" >
            <ItemTemplate>

            Product Name: <asp:Label ID="Name" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label><br />
            Product price: <asp:Label ID="price" runat="server" Text='<%# Eval("ProductPrice") %>'></asp:Label><br />

            </ItemTemplate>
        </asp:Repeater>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectwithJioMartDatabase %>" SelectCommand="SELECT ProductName, ProductPrice FROM JioMart.ProductDetails"></asp:SqlDataSource>--%>
    </div>

</asp:Content>