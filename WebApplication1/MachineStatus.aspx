﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MachineStatus.aspx.cs" Inherits="WebApplication1.MachineStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    
    <table class="w-100">
        <tr>
            <td>
                <asp:GridView ID="GridView2" 
                    runat="server" 
                    AutoGenerateColumns="False" 
                    Height="276px" 
                    Width="267px" 
                    onrowdatabound="Row_Color" CellPadding="4" ForeColor="#333333" GridLines="None"
                    >


                    <AlternatingRowStyle BackColor="White" />


                    <Columns>  

                            <asp:BoundField DataField="MACHINE_NAME" HeaderText="MACHINE NAME"/>

                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
    </table>


    
    
</asp:Content>
