<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControll.ascx.cs" Inherits="WebFormsTestTaskEmailSender.UserControll" %>
<asp:Label ID="EmailLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:TextBox ID="EmailInput" runat="server" OnTextChanged="EmailInput_TextChanged" CssClass ="EmailInput"></asp:TextBox>
<br />
<asp:Label ID="InvalidEmailLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:Label ID="MessageLabel" runat="server" Text="Label"></asp:Label>
<br />
<asp:TextBox ID="MessageInput" runat="server" CssClass ="MessageInput" Rows="10" TextMode="MultiLine" OnTextChanged="MessageInput_TextChanged"></asp:TextBox>
<br />
<asp:Button ID="SendButton" runat="server" Text="Button" OnClick="SendButton_Click" />

