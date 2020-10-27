<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="usercost.aspx.cs" Inherits="EAOF_by_ritu.userchart" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="manu" runat="server">
    <a href="logout.aspx" class="right"><b>Logout</b>
</a></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT DISTINCT [txtuid] FROM [pl0253]"></asp:SqlDataSource>
    <asp:BarChart ID="BarChart1" runat="server" ChartHeight="800" ChartWidth="1000"></asp:BarChart>
    
</asp:Content>
