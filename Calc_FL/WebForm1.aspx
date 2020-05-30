<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calc_FL.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:TextBox class="form-control-sm" onkeypress="javascript:return solonumeros(event)" ID="TextBox1" runat="server" BorderColor="#009933" BorderStyle="Solid"  BackColor="#CCFFCC"></asp:TextBox>
    <asp:TextBox class="form-control-sm" ID="TextBox2" onkeypress="javascript:return solonumeros(event)" runat="server" BorderColor="#009933" BorderStyle="Solid" BackColor="#CCFFCC"></asp:TextBox>
    <br />
    <br />
    <asp:Button class="btn btn-success" ID="Sumar_btn" runat="server" Text="+" OnClick="Button1_Click" />
    <asp:Button class="btn btn-success" ID="Restar_btn" runat="server" Text="-" OnClick="Button2_Click" />
    <asp:Button class="btn btn-success" ID="Multiplicar_btn" runat="server" Text="*" OnClick="Button3_Click" />
    <asp:Button class="btn btn-success" ID="Division_btn" runat="server" Text="/" OnClick="Button4_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="lbl1" runat="server"></asp:Label>
<br />
&nbsp;&nbsp;
    <asp:Label ID="Resul_txt" runat="server" Text="Resultado"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="resultados finales" BorderStyle="Groove" ForeColor="#66FF66" />
    <br />
</asp:Content>
