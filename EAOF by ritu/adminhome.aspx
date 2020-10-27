<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="EAOF_by_ritu.adminhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="manu" runat="server">
    <a href="logout.aspx" class="right"><b>Logout</b></a>
     <a href="chart.aspx" class="right"><b>Show Chart</b></a>
    <a href="userdetail.aspx" class="left"><b>User Detail</b></a>
    <a href="cropdetail.aspx" class="left"><b>Crop Detail</b></a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <center>
        <img src="img/avtar.png" height="300px" width="300px"  ></img>
     </center>
</asp:Content>
