<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Admin_login_6.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/StyleSheet2.css" rel="stylesheet" />
    
    <div class="back_img center"> 
        <p class="para">Admin Control Panel</p>
        <div class="header">
            <div class="input col" style="margin-top:120px" >
            <asp:TextBox Class="test textbox" ID="TextBox_text1" runat="server" type="text" BackColor="White" placeholder="Text - 1" ForeColor="Black" Style="text-align:center"></asp:TextBox><label>Text - 1</label>
                <span class="focus-border">
               <i></i>
                </span>
            </div>
            <br />
            <div class="input col" >
            <asp:TextBox Class="test textbox" ID="TextBox_text2" runat="server" placeholder="Text - 2" type="text" BackColor="White" ForeColor="Black" Style="text-align:center"></asp:TextBox><label>Text - 2</label>
                <span class="focus-border">
                        <i></i>
                       </span>
            </div>
            <br />
            <div class="input col" >
            <asp:TextBox Class="test textbox" ID="TextBox_header" runat="server" type="text" BackColor="White" placeholder="Header Text" ForeColor="Black" Style="text-align:center"></asp:TextBox><label>Header Text</label>
                <span class="focus-border">
                 <i></i>
                 </span>
            </div>
            <br />
            <div class="input col">
            <asp:TextBox Class="test textbox" ID="TextBox_footer" runat="server" placeholder="Footer Text" type="Text" BackColor="White" ForeColor="Black" Style="text-align:center"></asp:TextBox><label>Footer Text</label>
                <span class="focus-border">
                  <i></i>
                    </span>
                </div>
                <br />
                <div class="glow-on-hover center" style="margin-top:60px" >
                <asp:Button ID="Button_submit" runat="server" Text="Submit" BackColor="Black" BorderStyle="None" CausesValidation="True" EnableTheming="True" Enabled="True" EnableViewState="True" UseSubmitBehavior="True" ValidateRequestMode="Inherit" Visible="True" Font-Size="Larger" OnClick="Submit_click"  />
            </div>
        </div>
    </div>

</asp:Content>
