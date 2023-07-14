<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MachineStatusChange.aspx.cs" Inherits="WebApplication1.MachineStatusChange" %>






<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Machine Name:"></asp:Label>

        <asp:TextBox ID="macname" runat="server" Width="201px" Height="25px"></asp:TextBox>

    </p>
    <p>
 
        <asp:Button ID="Button1" runat="server" BackColor="#009933" BorderStyle="Double" ForeColor="White" Text="Çalıştır" OnClick="Button_Calistir"/>

        <asp:Button ID="Button2" runat="server" BackColor="#FB0B11" BorderStyle="Double" CausesValidation="False" ForeColor="White" Text="Durdur" OnClick="Button_Durdur"/>


</asp:Content>
