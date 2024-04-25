<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaPersonas.aspx.cs" Inherits="Examen02.Pages.ListaPersonas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Lista de personas</h2>

    <div style="margin-bottom: 10px;">
        <a href="CrearPersona.aspx" class="btn btn-primary">Crear persona</a>
    </div>

    <div class="primary-container">
        <asp:GridView ID="GvListarPersonas" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="idPersona" HeaderText="ID" />
                <asp:BoundField DataField="nombreProvincia" HeaderText="Provincia" />
                <asp:BoundField DataField="nombreCompleto" HeaderText="Nombre completo" />
                <asp:BoundField DataField="telefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha de nacimiento" DataFormatString="{0:d}" />
                <asp:BoundField DataField="salario" HeaderText="Salario" />
                <asp:BoundField DataField="edad" HeaderText="Edad" />
                <asp:BoundField DataField="generacion" HeaderText="Generacion" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="EditarPersona.aspx?id=<%# Eval("idPersona") %> ">Editar</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
