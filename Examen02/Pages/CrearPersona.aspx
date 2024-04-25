<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearPersona.aspx.cs" Inherits="Examen02.Pages.CrearPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Crear persona</h2>

    <div>

        <div>
            <span>Provincia</span>
            <asp:DropDownList ID="DdlProvincias" runat="server" Enabled="true"></asp:DropDownList>
        </div>

        <div>
            <span>Nombre completo</span>
            <asp:TextBox ID="TxtNombreCompleto" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>Teléfono (0000-0000)</span>
            <asp:TextBox ID="TxtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>Fecha nacimiento</span>
            <asp:TextBox ID="TxtFechaNacimiento" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <span>Salario</span>
            <asp:TextBox ID="TxtSalario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnGuardar" runat="server"
                Text="Guardar" BackColor="#006600"
                ForeColor="White" CssClass=" btn btn-primary"
                OnClick="BtnGuardar_Click" />
        </div>

        <div>
            <a href="ListaPersonas.aspx" class="btn btn-default">Cancelar</a>
        </div>
    </div>
</asp:Content>
