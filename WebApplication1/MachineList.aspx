<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MachineList.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    
    
    <table class="w-100" style="margin-bottom: 0px">
        <tr>
            <td style="height: 60px; width: 155px">
                

                    <br />
                    MACHINE NAME<br />
                    RECORDING DATE <br />
                    STATUS
            </td>
            <td style="width: 2px; height: 38px;">
                    <br />
                    <asp:TextBox ID="mac_name" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="rec_date" runat="server"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="mac_status" runat="server"></asp:TextBox>
              
            </td>
            <td style="height: 38px; width: 1px;">

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="156px" Width="583px">
                    <Columns>  
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckSelect" runat="server" />    
                            </ItemTemplate>
                        </asp:TemplateField>
                                <asp:BoundField DataField="ID" HeaderText="ID" />
                                <asp:BoundField DataField="MACHINE_NAME" HeaderText="Machine Name" />
                                <asp:BoundField DataField="REC_DATE" HeaderText="Record Date" />
                                <asp:BoundField DataField="STATUS" HeaderText="Status" />

                    </Columns>
                </asp:GridView>
            </td>


        </tr>
        <tr>
            <td style="width: 135px">
                &nbsp;<br />
                
                <br />
            </td>
            <td style="width: 2px">
                <asp:Button ID="Button1" runat="server" Text="Yeni Ekle" OnClick="Yeni_Ekle_Click" />
                
            </td>
            <td>
                <asp:Button 
                    ID="Button2" 
                    runat="server"  
                    Text="Sil" 
                    Width="106px" 
                    OnClick="Delete_Click"
                    />

                
                
            </td>

    </table>
</asp:Content>

