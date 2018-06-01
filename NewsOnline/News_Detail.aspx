<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="News_Detail.aspx.cs" Inherits="NewsOnline.News_Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="side-overskrifter">News_Detail ...</h1>
    <br />
    <asp:Literal ID="litNews" runat="server" />
</asp:Content>
