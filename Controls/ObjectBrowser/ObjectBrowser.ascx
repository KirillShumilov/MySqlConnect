<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ObjectBrowser.ascx.cs" Inherits="Controls.ObjectBrowser.ObjectBrowser" %>
<%@ Register TagPrefix="asp" Namespace="App_Code.CustomTree" Assembly="App_Code" %>
<asp:ObjectTreeView ID="objectTree" runat="server" Height="371px" Width="234px" 
    PopulateNodesFromClient="False" EnableClientScript="False" 
    ontreenodepopulate="objectTree_TreeNodePopulate">
</asp:ObjectTreeView>

