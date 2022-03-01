<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Admin_login_6.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <link href="Content/StyleSheet1.css" rel="stylesheet" />
    
    <div class="bg_col center">
        <div class="header">        
            <img src="image/R.889f060e8c5d8ecf1641615f49de1c2f.png" height="150px" width="150px" /> 
            <br />
            <br />
              <div class="input col">
            <asp:TextBox Class="test textbox" ID="TextBox_username" runat="server" type="text" BackColor="White" placeholder="User Name" ForeColor="Black" Style="text-align:center"></asp:TextBox><br /><label>User Name</label>
                <span class="focus-border">
                 <i></i>
                </span>             
            </div>
            <br />
            <div class="input col">
            <asp:TextBox Class="test textbox" ID="TextBox_password" runat="server" placeholder="Password" type="Password" BackColor="White" ForeColor="Black" Style="text-align:center"></asp:TextBox><label>Password</label>
                <span class="focus-border">
                  <i></i>
                     </span>
            </div>
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="" ForeColor="Red" Font-Underline="False" Font-Size="10px"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <div class="glow-on-hover center">
                <asp:Button ID="Button_login" runat="server" Text="Login" BackColor="Black" BorderStyle="None" CausesValidation="True" EnableTheming="True" Enabled="True" EnableViewState="True" UseSubmitBehavior="True" ValidateRequestMode="Inherit" Visible="True" Font-Size="Larger" OnClick="Login_click" OnClientClick="return confirm('Are you sure you want to Login')" />
            </div>
            </div>
  </div>
     


</asp:Content>
