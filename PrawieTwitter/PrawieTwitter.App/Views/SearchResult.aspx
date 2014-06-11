<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="PrawieTwitter.App.Views.SearchResult" MasterPageFile="~/Site.Master"%>
<%@ import Namespace="PrawieTwitter.Library.Controllers" %>
<%@ import Namespace="PrawieTwitter.Library.Entities" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="Content">
    <h2> Wyniki wyszukiwania. <%Response.Write(Session["SearchResult"]); %>
    </h2> 
    
    <%foreach(User u in ((List<User>)Session["SearchResult"])){ %>
        <a href="Wall.aspx"><% Response.Write(u.FirstName); %></a>
    <%} %>
</asp:Content>