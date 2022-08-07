<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="USUARIO_INEXISTENTE.aspx.cs" Inherits="Clinica_Medica.USUARIO_INEXISTENTE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h2>No tiene permisos para utilizar esta aplicacion</h2>
        </div>
        <div>
            <asp:Button ID="btnVolverLogin" runat="server" Text="Volver" OnClick="btnVolverLogin_Click" />
        </div>
    </form>
</body>
</html>
