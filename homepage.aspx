<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="ticket_system.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="wave d-flex align-items-center justify-content-center">
       <h2>System ticketowy</h2>
       <h2>System ticketowy</h2>
    </div>
    <br />
    <br />
    <br />
    <br />
    <div class="login d-flex align-items-center justify-content-center">
         <asp:LinkButton ID="gotologin" runat="server" OnClick="gotologin_Click"><h3>Strona logowania</h3></asp:LinkButton>
    </div>
    <br />
    <br />
</asp:Content>
