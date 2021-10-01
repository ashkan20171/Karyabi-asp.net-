<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/CustomerMasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerPanel.aspx.cs" Inherits="Karyabi.UserPanel.CustomerPanel" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cphUserInfo" runat="server">
   
    <div id="lblusername" runat="server"></div>
    <br />
    <div id="lblFullName" runat="server" ></div> 
    
 

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="cphSubUserInfo" runat="server">

    <div id="lblState" runat="server"> </div>
    <asp:Button ID="btnExit" Text="خـروج" runat="server" OnClick="btnExit_Click" CssClass="btnExit"  />
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="cphMain" runat="server">

</asp:Content>
