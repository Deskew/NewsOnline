<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="News_Type1.aspx.cs" Inherits="NewsOnline.News_Type1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1 class="side-overskrifter">新闻 - 按类别</h1>
    <br />
    <div class="div-login">
    <asp:DropDownList ID="ddlNewsType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlNewsType_SelectedIndexChanged" CssClass="txt-login" >
        <asp:ListItem Text="选择一个新闻类型" disabled="disabled" Selected="True"></asp:ListItem>
        <asp:ListItem Text="显示所有新闻" disabled="disabled" Selected="false"></asp:ListItem>
    </asp:DropDownList>
    <asp:Literal ID="litResult" runat="server" />
        </div>
</asp:Content>