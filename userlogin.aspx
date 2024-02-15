﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="ticket_system.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container mt-5">
    <div class="card mx-auto" style="max-width: 400px; border: 3px solid">
      <div class="card-header bg-primary text-white text-center rounded-5">
        <h2>Zaloguj się</h2>
      </div>
      <div class="card-body">
        
          <div class="form-group">
            <label for="login">Login:</label>
            <input type="text" class="form-control" id="login" placeholder="Wpisz login">
          </div>
          <div class="form-group">
            <label for="password">Hasło:</label>
            <input type="password" class="form-control" id="password" placeholder="Wpisz hasło">
          </div>
          <asp:LinkButton class="btn btn-success btn-block btn-lg" runat="server" Text="Zaloguj" OnClick="Unnamed1_Click" />
        
      </div>
    </div>
  </div>
   <br />
</asp:Content>
