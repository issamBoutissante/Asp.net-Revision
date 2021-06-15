<%@ Page Title="" Language="C#" MasterPageFile="~/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="GestionOperation.aspx.cs" Inherits="Exercice_de_Revision_WCS_1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table>
        <tr>
            <td>
                <label>Compte</label>
            </td>
            <td>
                <asp:DropDownList ID="Comptes" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nom" DataValueField="Compte" />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MonConnection %>" SelectCommand="SELECT [Compte], [Nom] FROM [Client]"></asp:SqlDataSource>
            </td>
        </tr>

        <tr>
            <td>
                <label>Type</label>
            </td>
            <td>
                <asp:DropDownList ID="Types" runat="server" >
                    <asp:ListItem>Versement</asp:ListItem>
                    <asp:ListItem>Retrait</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>
                <label>Montant</label>
            </td>
            <td>
                <asp:TextBox CssClass="text" ID="Montant" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Affecter" CssClass="btn" Text="Affecter" runat="server" OnClick="Affecter_Click"/>
            </td>
            <td>
                <asp:Label ID="Message" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
