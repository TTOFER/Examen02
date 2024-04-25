<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MensajeRegistrar.aspx.cs" Inherits="Examen02.Pages.Mensaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Proceso completado con éxito</h2>

    <div class="alert-success">
        <p>Ha registrado correctamente los datos de una persona en la base de datos</p>
    </div>

    <div>
        <a href="ListaPersonas.aspx">REGRESAR</a>
    </div>
</asp:Content>
