<%@ Page Title="" Language="C#" MasterPageFile="~/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="ConsumerService.aspx.cs" Inherits="Exercice_de_Revision_WCS_1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
            <tr>
                <td>
                    <label>Mois</label>
                </td>
                <td>
                    <asp:TextBox CssClass="text" ID="Mois" runat="server"></asp:TextBox>
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
        <asp:GridView ID="ClientGridView" runat="server" ShowHeaderWhenEmpty="true">
        </asp:GridView>
</asp:Content>
