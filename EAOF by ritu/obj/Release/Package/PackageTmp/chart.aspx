<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="chart.aspx.cs" Inherits="EAOF_by_ritu.chart" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="manu" runat="server">
    <a href="logout.aspx" class="right"><b>Logout</b></a>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Label ID="lbl1" runat="server" Text="Select User"></asp:Label><asp:DropDownList ID="ddl1" runat="server" DataSourceID="SqlDataSource1" DataTextField="uid" DataValueField="uid" ></asp:DropDownList>
    <asp:Button ID="btn1" runat="server" Text="View Graph" OnClick="btn1_Click" />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT DISTINCT [uid] FROM [showgraph0253]"></asp:SqlDataSource>
    <asp:BarChart ID="BarChart1" runat="server" ChartHeight="500" ChartWidth="600"></asp:BarChart>
</asp:Content>
