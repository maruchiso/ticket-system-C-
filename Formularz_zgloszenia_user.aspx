<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formularz_zgloszenia_user.aspx.cs" Inherits="ticket_system.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container mx-auto text-center" id="panel_zgloszenia">
        <div class="row">
            <div class="col-12">
                Zgłoszenie ID
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <asp:Label runat="server" ID="ID_zgloszenia" Text=""></asp:Label>
            </div>
        </div>
        <br /><br />
        <div class="row">
            <div class="col-12">
                Tytuł
            </div>
        </div>
                <div class="row">
                    <div class="col-12">
                        <asp:TextBox runat="server" ID="Tytul_zgloszenia" ForeColor="Black" Columns="100"/>
                    </div>
                </div>
        <br /><br />
        <div class="row">
            <div class="col-12">
                <!--<asp:Label BackColor="WindowFrame" Text="Zgłoszenia" runat="server"></asp:Label>-->
                Priorytet
            </div>
        </div>
                <div class="row">
            <div class="col-12">
                        <asp:DropDownList runat="server" ID="Priorytet_zgloszenia" CssClass="btn btn-primary dropdown-toggle">
                            <asp:ListItem Text="P1" Value="P1"/>
                            <asp:ListItem Text="P2" Value="P2"/>
                            <asp:ListItem Text="P3" Value="P3"/>
                            <asp:ListItem Text="P4" Value="P4"/>
                            <asp:ListItem Text="P5" Value="P5"/>
                        </asp:DropDownList>
                 
             </div>
        </div>
        <br /><br />
        <div class="row">
            <div class="col-12">
                Opis
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <asp:TextBox runat="server" ID="Opis" TextMode="MultiLine" Rows="4" Columns="50" ForeColor="Black"></asp:TextBox>
            </div>
        </div>
        <br /><br /><br />
        <div class="row">
            <div class="col-12">
                <asp:LinkButton runat="server" Text="Zgłoś" CssClass="Zglos_Button btn btn-success btn-lg" ID="Guzik_Zglos" OnClick="Guzik_Zglos_Click"></asp:LinkButton>
            </div>
        </div>
        <br />
    </div>
</asp:Content>
