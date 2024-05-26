<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formularz_zgloszenia_admin.aspx.cs" Inherits="ticket_system.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="mb-4"></div>
        <div class="row justify-content-between mb-4">
            <div class="col-md-2 text-center">
                <div class="form-group">
                    <label>Priorytet:</label>
                    <asp:Label ID="Priorytet" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>

            <div class="col-md-4 text-center">
                <div class="form-group">
                    <label>Kto zgłosił:</label>
                    <asp:Label ID="KtoZglosil" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-6 text-center">
                <div class="form-group">
                    <label>Data zgłoszenia:</label>
                    <asp:Label ID="DataZgloszenia" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-4 text-center">
                <div class="form-group">
                    <label>ID zgłoszenia:</label>
                    <asp:Label ID="ID" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-10 text-center">
                <div class="form-group">
                    <label>Tytuł:</label>
                    <asp:Label ID="Tytul" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-10 text-center">
                <div class="form-group">
                    <label>Opis:</label>
                    <asp:Label ID="Opis" runat="server" CssClass="form-control"></asp:Label>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-12 text-center">
                <div class="form-group">
                    <label>Informacja od Pracownika IT:</label>
                    <asp:TextBox ID="InformacjaIT" runat="server" CssClass="form-control text-center" TextMode="MultiLine" Rows="4" ></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <div class="col-md-2 text-center">
                <div class="form-group">
                    <label>Status:</label>
                    <asp:DropDownList ID="StatusBox" runat="server" CssClass="form-control text-center">

                        <asp:ListItem>OPEN</asp:ListItem>
                        <asp:ListItem>NEW</asp:ListItem>
                        <asp:ListItem>CLOSE</asp:ListItem>

                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row justify-content-center mb-4">
            <asp:Button ID="Save" runat="server" Text="Zapisz" CssClass="btn btn-primary btn-lg col-md-2" OnClick="Save_Click" />
            <asp:Label ID="StatusLabel" runat="server" CssClass="form-control"></asp:Label>
        </div>
    </div>
</asp:Content>
