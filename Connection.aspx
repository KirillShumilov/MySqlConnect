<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Connection.aspx.cs" Inherits="Connection" %>

<%@ Register src="Controls/Connector/ConnectionControl.ascx" tagname="ConnectionControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:ConnectionControl ID="connectionControl" runat="server" />
</asp:Content>

