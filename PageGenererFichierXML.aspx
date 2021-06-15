<%@ Page Title="" Language="C#" MasterPageFile="~/PagePrincipal.Master" AutoEventWireup="true" CodeBehind="PageGenererFichierXML.aspx.cs" Inherits="Exercice_de_Revision_WCS_1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height:80vh;display:flex;align-items:center;justify-content:center;">
        <table>
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
                    <asp:Button CssClass="btn" ID="GenereFichierXML" Text="Generer Fichier XML" runat="server" OnClick="GenereFichierXML_Click"/>
                </td>
                <td>
                    <asp:Label ID="Message" runat="server" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
