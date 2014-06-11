<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YourWall.aspx.cs" Inherits="PrawieTwitter.App.Views.YourWall" MasterPageFile="~/Site.Master" %>
<%@ import Namespace="PrawieTwitter.Library.Controllers" %>
<%@ import Namespace="PrawieTwitter.Library.Entities" %>
<asp:Content runat="server" ContentPlaceHolderID="Content">
    <asp:ListView runat="server">
        <ItemTemplate>


        </ItemTemplate>
    </asp:ListView>
    <% foreach(Status s in StatusController.FindByUser(((User)Session["LoginUser"]).Id)){ %>
        
    <%} %>

</asp:Content>