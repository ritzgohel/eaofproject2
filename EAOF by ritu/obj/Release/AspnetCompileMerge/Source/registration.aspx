<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="EAOF_by_ritu.registration" %>

<asp:Content ID="Content2" ContentPlaceHolderID="manu" runat="server">
    <a href="login.aspx" class="right"><b>Login</b></a>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="content" runat="server">
    <table align="center" style="  font-family: 'Arial Rounded MT Bold'; font-size: medium; font-weight: bold; font-style: normal; font-variant: normal; background-color: lavender">
        <tr>
           <td style="width: 719px; top: auto; right: auto; left: auto; font-size: x-large; font-weight: bold; background-color: #C0C0C0;">
        <table align="center">
        
         <tr>
            <td colspan="2" style="font-family: Arial, Helvetica, sans-serif; font-size:xx-large; font-weight: bolder; font-style: normal; font-variant: normal; line-height: normal; vertical-align: middle; text-align: center; color:darkslateblue;" >
                <br />
                Registration<br />
                <br />
             </td>
         </tr>
     
        <tr>
            <td style="width: 859px" >&nbsp;&nbsp;&nbsp;&nbsp; First Name:</td>
            <td style="margin-left: 40px; width: 486px;"><asp:TextBox ID="txtfname" runat="server" Height="32px" Width="400px"></asp:TextBox>
                <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txtlname" ErrorMessage="First Name is require" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>

            </tr>
      

        <tr>
            <td style="height: 19px; width: 859px;">&nbsp;&nbsp;&nbsp;&nbsp; Last Name:</td>
            <td style="height: 19px; width: 486px;">
                <asp:TextBox ID="txtlname" runat="server" CssClass="tb" Height="32px" Width="400px"></asp:TextBox>
               

                <br />
               

                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtlname" ErrorMessage="Surname  is require" ForeColor="Red"></asp:RequiredFieldValidator>
               

            </td>
        </tr>
        
        <tr>
            <td style="width: 859px">&nbsp;&nbsp;&nbsp;&nbsp; Mobile No:</td>
            <td style="width: 486px">
                <asp:TextBox ID="txtmobile" runat="server" MaxLength="10" TextMode="Number" CssClass="tb" Height="32px" Width="400px"></asp:TextBox>
               

                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtmobile" ErrorMessage="Mobile Number is require" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionPhone" runat="server" Text="Only 10 Numeric!!!"
                                ForeColor="Red" ControlToValidate="txtmobile" ValidationExpression="^\d{10}$">
                            </asp:RegularExpressionValidator>
            </td>        
        </tr>
            <tr>
                <td style="height: 26px; width: 859px;">&nbsp;&nbsp;&nbsp;&nbsp; District:</td>
                <td style="height: 40px; width: 486px;"> <asp:DropDownList ID="dddistrict" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="district_name" DataValueField="dist_id" Height="29px" Width="179px">
                    <asp:ListItem Value="-1">--select--</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="select district" ForeColor="Red" ControlToValidate="dddistrict"></asp:RequiredFieldValidator>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT * FROM [district0253]"></asp:SqlDataSource>
                </td>
            </tr>
             <tr>
                <td style="height: 26px; width: 859px;">&nbsp;&nbsp;&nbsp;&nbsp; Taluka:</td>
                <td style="height: 40px; width: 486px;"> <asp:DropDownList ID="ddtaluka" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="t_nm" DataValueField="talukaId" Height="31px" Width="182px">
                    <asp:ListItem Value="-1">--select--</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="select Taluka" ForeColor="Red" ControlToValidate="ddtaluka"></asp:RequiredFieldValidator>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT * FROM [taluka0253] WHERE ([dist_id] = @dist_id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="dddistrict" Name="dist_id" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 859px">&nbsp;&nbsp;&nbsp;&nbsp; Village:</td>
                <td style="width: 486px"> <asp:DropDownList ID="ddvillage" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="village_name" DataValueField="village_Id" Height="30px" Width="178px">
                    <asp:ListItem Value="-1">--select--</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                       <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" SelectCommand="SELECT * FROM [village0253] WHERE ([talukaId] = @talukaId)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddtaluka" Name="talukaId" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
         <tr>
            <td style="width: 859px; height: 125px;">&nbsp;&nbsp;&nbsp;&nbsp; Username:</td>
            <td style="width: 486px; height: 125px;">
                <br />
                <br />
                <asp:TextBox ID="txtuid" runat="server" CssClass="tb" Height="32px" Width="400px"></asp:TextBox>
               

                <br />
               

                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="txtuid" ErrorMessage="Username  is require" ForeColor="Red"></asp:RequiredFieldValidator>
                 <asp:CustomValidator ID="CustomValidatoruser" runat="server" ErrorMessage="This Username has already been taken"
                                OnServerValidate="CustomValidatoruser_ServerValidate"  ForeColor="Red" ControlToValidate="txtuid" ></asp:CustomValidator>

             </td>        
        </tr>
         <tr>
            <td style="width: 859px; height: 85px;">&nbsp;&nbsp;&nbsp;&nbsp; Password:</td>
            <td style="width: 486px; height: 85px;">
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" CssClass="tb" Height="32px" Width="400px"></asp:TextBox>
               

                <br />
               

                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="txtpwd" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
               

             </td>        
        </tr>
         <tr>
            
             <td style="width: 859px; top: 0px;">&nbsp;&nbsp;&nbsp;&nbsp; Confirm<br />
&nbsp;&nbsp;&nbsp; Password:</td>
            <td style="width: 486px">
                 <asp:TextBox ID="txtcpwd" runat="server" TextMode="Password" CssClass="tb" Height="32px" Width="400px"></asp:TextBox>
               

                <br />
               

                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="txtcpwd" ErrorMessage="Plese Rewrite the password" ForeColor="Red"></asp:RequiredFieldValidator>
               

                <br />
               

                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtcpwd" ErrorMessage="Password and Confirm password must be same" ForeColor="#3366FF"></asp:CompareValidator>
               

             </td>        
        </tr>
         
              <tr>
            <td align="center" style="width: 859px"><asp:Button ID="btnsubmit" runat="server" Text="Submit"  BackColor="#99FF33" Width="94px" ForeColor="White" Height="49px" OnClick="btnsubmit_Click" /></td>
            <td style="width: 486px"><asp:Button ID="btncancel" runat="server" Text="Cancel" BackColor="#FF6600" Width="94px" ForeColor="White" Height="50px"  /></td>        
            
    </table>
</table>
</asp:Content>
