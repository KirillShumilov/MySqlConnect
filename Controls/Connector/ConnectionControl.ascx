<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ConnectionControl.ascx.cs" Inherits="Controls.Connector.ConnectionControl" %>
<div style="height: 271px">
    <asp:Label ID="lblHostName" runat="server" Text="Host name"></asp:Label>
    <br />
    <asp:TextBox ID="teHostName" runat="server" Width="270px">w2k3_mysql5</asp:TextBox>
    <br />
    <asp:Label ID="lblLogin" runat="server" Text="User name"></asp:Label>
    <br />
    <asp:TextBox ID="teLogin" runat="server" Width="270px">root</asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="tePassword" runat="server" TextMode="Password" Width="270px">root</asp:TextBox>
    <br />
    <asp:Label ID="lblDatabase" runat="server" Text="Database"></asp:Label>
    <br />
    <asp:TextBox ID="teDatabase" runat="server" Width="270px"></asp:TextBox>
    <br />
    <asp:Label ID="lblPort" runat="server" Text="Port"></asp:Label>
    <br />
    <asp:TextBox ID="tePort" runat="server" Width="270px">3306</asp:TextBox>
    <br />
    <asp:Button ID="btnConnect" runat="server" onclick="btnConnect_Click" 
        Text="Connect" />
    <br />
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</div>
<p>
    &nbsp;</p>
<br />

