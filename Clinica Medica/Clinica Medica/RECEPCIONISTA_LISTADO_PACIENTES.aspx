<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTA_LISTADO_PACIENTES.aspx.cs" Inherits="Clinica_Medica.RECEPCIONISTA_LISTADO_PACIENTES" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvListadoPacientes" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvListadoPacientes_SelectedIndexChanged" OnRowDeleting="gvListadoPacientes_RowDeleting">
                         
                    <columns>
                        
                        <asp:BoundField HeaderText="ID" DataField="Id"/>
                        <asp:BoundField HeaderText="NOMBRE" DataField="Nombre"/>
                        <asp:BoundField HeaderText="APELLIDO" DataField="Apellido"/>
                        <asp:BoundField HeaderText="USUARIO" DataField="User"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="MODIFICAR" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderText="ELIMINAR" />
                    </columns>

            </asp:GridView>
        </div>
        
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="VOLVER" OnClick="btnVolver_Click" />
        </div>

        <div>
            <asp:Panel ID="panelBorrar" runat="server" visible="false">
               <h5><asp:Label ID="lblPanelBorrar"  runat="server" Text="Desea Eliminar El Registro?"></asp:Label></h5>
               <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
               <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            </asp:Panel>
        </div>

    </form>
</body>
</html>
