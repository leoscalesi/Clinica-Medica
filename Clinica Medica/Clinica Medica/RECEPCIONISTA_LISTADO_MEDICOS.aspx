<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RECEPCIONISTA_LISTADO_MEDICOS.aspx.cs" Inherits="Clinica_Medica.RECEPCIONISTA_LISTADO_MEDICOS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:GridView ID="gvListadoMedicos" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvListadoMedicos_RowDeleting" OnSelectedIndexChanged="gvListadoMedicos_SelectedIndexChanged">
                         
                    <columns>
                        
                        <asp:BoundField HeaderText="IDMEDICO" DataField="Usuario.Medico.IdMedico"/>
                        <asp:BoundField HeaderText="NOMBRE" DataField="Usuario.Nombre"/>
                        <asp:BoundField HeaderText="APELLIDO" DataField="Usuario.Apellido"/>
                        <asp:BoundField HeaderText="NRO MATRICULA" DataField="Usuario.Medico.NroMatricula"/>
                        
                        <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="MODIFICAR" />
                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" HeaderText="ELIMINAR" />
                    </columns>

         </asp:GridView>
        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="VOLVER" OnClick="btnVolver_Click" />
        </div>
    
    </form>
</body>
</html>
