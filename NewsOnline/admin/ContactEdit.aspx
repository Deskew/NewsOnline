<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ContactEdit.aspx.cs" Inherits="NewsOnline.admin.ContactEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="div-login">
    <asp:TextBox ID="txtFirmName" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtAddress" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtPostNummer" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtBy" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtTelePhone" runat="server" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtEmail" runat="server" CssClass="txt-login" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="确认修改" OnClick="btnSend_Click" CssClass="btn-login" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>
