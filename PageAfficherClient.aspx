<%@ Page Title="" Language="C#" MasterPageFile="~/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="PageAfficherClient.aspx.cs" Inherits="Exercice_de_Revision_WCS_1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
            <tr>
                <td>
                    <label>Numero Compte</label>
                </td>
                <td>
                    <asp:DropDownList CssClass="text" ID="Comptes" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nom" DataValueField="Compte"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MonConnection %>" SelectCommand="SELECT [Nom], [Compte] FROM [Client]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <label>Date 1</label>
                </td>
                <td>
                    <asp:TextBox CssClass="text" ID="Date1" TextMode="Date" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label>Date 2</label>
                </td>
                <td>
                    <asp:TextBox CssClass="text" ID="Date2" TextMode="Date" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <label>Solde</label>
                </td>
                <td>
                    <asp:TextBox CssClass="text" ID="Solde" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button CssClass="btn" ID="Afficher" Text="Afficher" runat="server" OnClick="Afficher_Click"/>
                </td>
                <td>
                    <asp:Label ID="Message" runat="server" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="historiqueGridView" runat="server" ShowHeaderWhenEmpty="true">
        </asp:GridView>
</asp:Content>
