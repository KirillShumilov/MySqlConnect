<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Working.aspx.cs" Inherits="Working" %>

<%@ Register src="Controls/ObjectBrowser/ObjectBrowser.ascx" tagname="ObjectBrowser" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <uc1:ObjectBrowser ID="objectBrowser" runat="server" />
</asp:Content>

