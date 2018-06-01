<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="NewsEdit.aspx.cs" Inherits="NewsOnline.admin.NewsEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="div-login">
    <asp:TextBox ID="txtTitle" runat="server" placeholder="标题" autofocus="true" CssClass="txt-login" />
    <br />
    <asp:TextBox ID="txtPreview" runat="server" placeholder="简略信息" TextMode="MultiLine" CssClass="txt-multiline" />
    <br />
    <asp:TextBox ID="txtText" runat="server" placeholder="详细内容" TextMode="MultiLine" CssClass="txt-multiline" />
    <br />
    <asp:DropDownList ID="ddlNewsType" runat="server" AutoPostBack="true" CssClass="txt-login" />
    <br />
    <asp:Image ID="imgImage" runat="server" />
    <br />
    <asp:CheckBox ID="chbImg" runat="server" Text="删除图像" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" />
    <br />
    <asp:Button ID="btnSend" runat="server" Text="确认修改" OnClick="btnSend_Click" CssClass="btn-login" />
    <br />
    <asp:Literal ID="litResult" runat="server" />
    </div>
</asp:Content>
