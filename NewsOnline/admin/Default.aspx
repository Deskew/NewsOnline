<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsOnline.admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3 class="side-overskrifter">欢迎来到学院新闻在线管理后台(CMS)</h3>
    <h1 class="side-overskrifter"></h1>
    <h1 class="side-overskrifter">最新要闻 ...</h1>
    <br />
    <asp:Literal ID="litNews" runat="server" />
    <br />
    <div class="line"></div>
    <br />
    <br />

</asp:Content>
