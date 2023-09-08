<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="JioMartApp.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
<%--    <div>  
        <asp:GridView ID="ProductView" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ProductView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ProductDetailsId" HeaderText="ProductDetailsId" InsertVisible="False" ReadOnly="True" SortExpression="ProductDetailsId" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
                <asp:BoundField DataField="ProductStockQuantity" HeaderText="ProductStockQuantity" SortExpression="ProductStockQuantity" />
                <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
              
            </Columns>
        </asp:GridView>
 

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectwithJioMartDatabase %>" SelectCommand="SELECT ProductDetailsId, ProductName, ProductPrice, ProductStockQuantity, CategoryId, CreatedOn, UpdatedOn FROM JioMart.ProductDetails"></asp:SqlDataSource>
 

    </div>  --%>



</asp:Content>
