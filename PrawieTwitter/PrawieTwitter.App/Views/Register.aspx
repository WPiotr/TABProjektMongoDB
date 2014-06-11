<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PrawieTwitter.App.Views.Register" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="Content">
    <h2 style="margin: 10px;">Rejestracja</h2>
    
    <table>
        <tr>
            <td>
                <label>Imie:</label>
                
            </td>
            <td>
                <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Nazwisko:</label>
                
            </td>
            <td>
                <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Email:</label>
                
            </td>
            <td>
                <asp:TextBox ID="email" TextMode="Email" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Wiek:</label>
                
            </td>
            <td>
                <asp:TextBox ID="age" TextMode="Number" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Hasło:</label>
                
            </td>
            <td>
                <asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <label>Powtórz Hasło:</label>
            </td>
            <td>
                <asp:TextBox ID="secPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Text="Rejestruj" OnClick="RegisterUser" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label runat="server" ID="Err" Visible="false" style="color:red;"></asp:Label>
            </td>
        </tr>



    </table>


</asp:Content>
