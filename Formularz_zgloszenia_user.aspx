<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formularz_zgloszenia_user.aspx.cs" Inherits="ticket_system.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mx-auto text-center">
        <div class="row">
            <div class="col-12">
                Zgłoszenie ID
                <asp:Label runat="server" ID="ID_zgloszenia" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                Tytuł
                <asp:TextBox runat="server" ID="Tytul_zgloszenia" />
            </div>
        </div>
        <div class="row">
            <div class="col-12">

                    <asp:DropDownList runat="server" ID="Priorytet_zgloszenia" CssClass="form-control">
                        <asp:ListItem Text="P1" Value="P1"/>
                        <asp:ListItem Text="P2" Value="P2"/>
                        <asp:ListItem Text="P3" Value="P3"/>
                        <asp:ListItem Text="P4" Value="P4"/>
                        <asp:ListItem Text="P5" Value="P5"/>
                    </asp:DropDownList>
                    
                </div>
        </div>
        <div class="row">
            <div class="col-12">
                Opis
            </div>
        </div>
    </div>
</asp:Content>
