﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTA_PRINCIPAL.aspx.cs" Inherits="Clinica_Medica.RECEPCIONISTA_PRINCIPAL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Gestión de Turnos</h2>
        </div>
        <div>
            <asp:Label ID="lblHolaRecepcionista" runat="server" Text="Bienvenido/a "></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnCargarAgenda" runat="server" Text="Cargar Agenda" OnClick="btnCargarAgenda_Click" />
        </div>
        <div>
            <asp:Button ID="btnBrindarTurnos" runat="server" Text="Brindar Turnos" OnClick="btnBrindarTurnos_Click" />
        </div>
        <div>
            <asp:Button ID="btnPacientes" runat="server" Text="Lista de Pacientes" OnClick="btnPacientes_Click" />
        </div>
        <div>
            <asp:Button ID="btnAltaPacientes" runat="server" Text="Alta de Pacientes" OnClick="btnAltaPacientes_Click" />
        </div>
        <div>
            <asp:Button ID="btnMedicos" runat="server" Text="Lista de Médicos" OnClick="btnMedicos_Click" />
        </div>
        <div>
            <asp:Button ID="btnAltaMedicos" runat="server" Text="Alta de Médicos" OnClick="btnAltaMedicos_Click" />
        </div>
        <div>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
        </div>
    </form>
</body>
</html>
