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
            <asp:GridView ID="gvListadoPacientes" runat="server" AutoGenerateColumns="False">
                         
                    <columns>
                        <!--EN DataField VAN LOS NOMBRES DE LAS PROPS -->
                        <asp:BoundField HeaderText="NOMBRE" DataField="Nombre"/>
                        <asp:BoundField HeaderText="APELLIDO" DataField="Apellido"/>
                        <asp:BoundField HeaderText="USUARIO" DataField="User"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="MODIFICAR" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderText="ELIMINAR" />
                    </columns>


            </asp:GridView>
        </div>
        
    </form>
</body>
</html>
