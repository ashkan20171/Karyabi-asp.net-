<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Karyabi.Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cphmain" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphlogin" runat="server">
    <center>
    <p>
    نام کاربری :
    <asp:TextBox ID="txt_username" runat="server" Height="27px" Width="127px"></asp:TextBox>
</p>
   
<p>
    کلمه عبور :
    &nbsp;
    <asp:TextBox ID="txt_password" runat="server" Height="27px" Width="127px"></asp:TextBox>
</p>
    
    <div id="lblErrormessge" runat="server"></div>
    <p >
       <asp:Button ID="btn_login" runat="server" Text="ورود" Height="20px" Width="50px" OnClick="btn_login_Click"/>

        </p>
    </center>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_new" runat="server">
    <asp:Literal ID="litOnlineUserCount" runat="server"></asp:Literal>
        <br />
    <asp:Literal ID="litSessionId" runat="server"></asp:Literal>
  
</asp:Content>

