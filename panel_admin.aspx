<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="panel_admin.aspx.cs" Inherits="ticket_system.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto text-center">
                <div class="my-4">
                    <h1>Moje zgłoszenia</h1>
                    <br />
                    <asp:GridView ID="Zgloszenia" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" >
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>

                            <asp:BoundField DataField="Tytul" HeaderText="Tytuł" HeaderStyle-Width="1000px">
                                <HeaderStyle CssClass="text-center"/>
                                <ItemStyle CssClass="text-center"/>
                            </asp:BoundField>

                            <asp:BoundField DataField="Status" HeaderText="Status" >
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>

                            <asp:BoundField DataField="Priorytet" HeaderText="Priorytet" >
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>

                            <asp:BoundField DataField="DataZgloszenia" HeaderText="Data Zgłoszenia" >
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>

                            <asp:BoundField DataField="KtoZglosil" HeaderText="Kto zgłosił?" >
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        
    </div>
</asp:Content>
