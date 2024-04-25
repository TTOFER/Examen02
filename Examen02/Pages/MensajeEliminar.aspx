<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MensajeEliminar.aspx.cs" Inherits="Examen02.Pages.MensajeEliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con éxito</h2>

    <div class="alert-success">
        <p>Ha borrado correctamente la información de la persona en la base de datos</p>
    </div>

    <div>
        <a href="ListaPersonas.aspx">REGRESAR</a>
    </div>
</asp:Content>
