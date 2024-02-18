<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="panel_user.aspx.cs" Inherits="ticket_system.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Moje zgłoszenia</h1>
        <br />
        <asp:GridView ID="Zgloszenia" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </div>
</asp:Content>
