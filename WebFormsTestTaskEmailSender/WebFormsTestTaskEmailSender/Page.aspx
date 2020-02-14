<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="WebFormsTestTaskEmailSender.Page" %>
<%@ Register src="UserControll.ascx" tagname="UserControll" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UserControll ID="UserControll2" runat="server" />
</asp:Content>
