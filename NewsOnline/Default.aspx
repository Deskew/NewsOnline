<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsOnline._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1 class="side-overskrifter">最新新闻 ...</h1>
    <br />
    <asp:Literal ID="litNews" runat="server" />
    <br />
    <div class="line"></div>
    <br />
    <br />

    <%--    <img src="http://lorempixel.com/400/200/" alt="Flot billede" />--%>

   <%-- <asp:Literal ID="litVidsteDu" runat="server" />--%>
</asp:Content>
