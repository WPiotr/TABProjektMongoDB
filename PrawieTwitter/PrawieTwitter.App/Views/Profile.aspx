<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PrawieTwitter.App.Views.Profile" 
 MasterPageFile="~/Site.Master"   %>


<asp:Content runat="server" ContentPlaceHolderID="Content">
    <h2>Profil użytkownika:</h2>
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
                <asp:Button runat="server" OnClick="ChangeCheck" Text="Zmiana hasła" /></td>
        </tr>
        <tr>
            <td>
                <label>Stare hasło:</label>
            </td>
            <td>
                <asp:TextBox Enabled="false" ID="oldPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <label>Hasło:</label>
                
            </td>
            <td>
                <asp:TextBox Enabled="false" ID="password" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <label>Powtórz Hasło:</label>
            </td>
            <td>
                <asp:TextBox Enabled="false" ID="secPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" Text="Zatwierdź dane" OnClick="Update" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label runat="server" ID="Err" Visible="false" style="color:red;"></asp:Label>
            </td>
        </tr>



    </table>

</asp:Content>