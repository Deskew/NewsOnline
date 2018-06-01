<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="All_News.aspx.cs" Inherits="NewsOnline.All_News" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="side-overskrifter">所有新闻 ...</h1>
    <br />
    <asp:Literal ID="litNews" runat="server" />
</asp:Content>
