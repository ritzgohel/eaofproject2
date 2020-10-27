<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="profitloss.aspx.cs" Inherits="EAOF_by_ritu.profitloss" %>

<asp:Content ID="Content2" ContentPlaceHolderID="manu" runat="server">
    <a href="Home.aspx" class="right"><b>Logout</b></a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
 
   <%-- <table align="center" style="background-color: #99FF99; width: 693px; margin-left: 0px;">
       <tr><td style="width: 593px">--%>
    <center>
   

    <table  style="width: 40%; font-family: Arial, Helvetica, sans-serif; font-size: medium; font-weight: bold; background-color:#99FF99; height: 555px;">
       <tr>
            <td style="width: 339px; height: 65px;">&nbsp; &nbsp; <span style="font-size: larger">
                <br />
                <br />
&nbsp;&nbsp;&nbsp; Year:<br />
                </span></td>
            <td style="height: 65px; width: 350px;">
                <br />
                <br />
                <asp:DropDownList ID="ddlyear" runat="server" Height="28px" Width="334px">
                    <asp:ListItem>-Select-</asp:ListItem>
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                    <asp:ListItem>1996</asp:ListItem>
                    <asp:ListItem>1997</asp:ListItem>
                    <asp:ListItem>1998</asp:ListItem>
                    <asp:ListItem>1999</asp:ListItem>
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2008</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>                  
                </asp:DropDownList>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="Select Year" ForeColor="Red" ControlToValidate="ddlyear"></asp:RequiredFieldValidator>
                <br />
            </td>         
        </tr> 
        <tr>
            <td style="width: 339px">&nbsp; &nbsp; <span style="font-size: larger"> <br />
                <br />
&nbsp;&nbsp;&nbsp; Crop Name:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <asp:TextBox ID="txtcropnm" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtcropnm" ErrorMessage="Enter Crop Name" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
            </td>         
        </tr>
    &nbsp;
        <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp; <span style="font-size: larger"> <br />
                <br />
&nbsp;&nbsp;&nbsp; Negotiation Price:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtnegoprice" runat="server" Height="28px" Width="334px" ></asp:TextBox>
                <br />
          


                <br />
            </td>           
        </tr>
         <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp;<span style="font-size: larger"> <br />
                <br />
&nbsp;&nbsp;&nbsp; Labour Cost:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtlbrcost" runat="server" Height="28px" Width="334px"  DefaultValue="0" ></asp:TextBox>
                <br />
                <br />
             </td>         
        </tr>
        
        <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp; <span style="font-size: larger">
                 <br />
                <br />
&nbsp;&nbsp;&nbsp; Fertilizer Cost:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtfertilizercost" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <br />
            </td>           
        </tr>
         <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp;<br />
&nbsp;<span style="font-size: larger"> <br />
                <br />
&nbsp;&nbsp;&nbsp; Seed Cost:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtseedcost" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <br />
             </td>         
        </tr>
         <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp; <span style="font-size: larger">
                 <br />
                <br />
&nbsp;&nbsp;&nbsp; Irrigation Cost:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtirrcost" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <br />
             </td>         
        </tr>
        <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp;<br />
&nbsp;<span style="font-size: larger"> <br />
                <br />
&nbsp;&nbsp;&nbsp; Machinery Charges:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtmachincharge" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <br />
            </td>           
        </tr>
        <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp; <span style="font-size: larger">
                <br />
                <br />
&nbsp;&nbsp;&nbsp; Electricity Bill:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <br />
                <asp:TextBox ID="txtelectricitybill" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
                <br />
            </td>           
        </tr>
         <tr>
            <td style="width: 339px">&nbsp;&nbsp;&nbsp; <span style="font-size: larger">
                 <br />
                <br />
&nbsp;&nbsp;&nbsp; Pesticide-insecticide Cost:<br />
                </span></td>
            <td style="width: 350px">
                <br />
                <br />
                <asp:TextBox ID="txtpicost" runat="server" Height="28px" Width="334px"></asp:TextBox>
                <br />
             </td>         
        </tr>
        <tr>
            <td align="center" colspan="2"><asp:Button ID="btnsubmit" runat="server" Text="Submit"  BackColor="#FF9933" Width="104px" ForeColor="White" Height="49px" Font-Bold="True" OnClick="btnsubmit_Click" /></td>                 
        </tr>    
            <tr>
           <td align="center" style="height: 23px; width: 339px; font-size: larger;"><b>
               <br />
               Gross Income=</b>
                <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>

                <br />

                <br />
               <b>Total Cost=</b><asp:Label ID="lblmsg2" runat="server" Text=""></asp:Label>
               <br />
                </td>
                <td align="center" style="height: 23px; font-size: larger; width: 350px;"><b>Net Income=</b>
                <asp:Label ID="lblmsg1" runat="server" Text=""></asp:Label>

                </td>

            </tr> 
   </table>
        </center>
    
<%--</td>
       </tr>
   </table>--%>
           
</asp:Content>
