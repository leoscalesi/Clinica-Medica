<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTA_ALTA_MEDICOS.aspx.cs" Inherits="Clinica_Medica.RECEPCIONISTA_ALTA_MEDICOS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
          <h2>Alta de Medicos</h2>
        </div>
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNroMatricula" runat="server" Text="Nro Matricula"></asp:Label>
            <asp:TextBox ID="txtNroMatricula" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div>
            <asp:ListBox ID="lbEspecialidades" runat="server"></asp:ListBox>
        </div>
        <div>
            <asp:Button ID="btnEliminarEspecialidades" runat="server" Text="Limpiar" OnClick="btnEliminarEspecialidades_Click" />
        </div>
        <div>
            <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click"/>
        </div>
    </form>
</body>
</html>
