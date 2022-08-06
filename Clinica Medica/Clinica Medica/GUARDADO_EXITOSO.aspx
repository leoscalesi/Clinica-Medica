<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GUARDADO_EXITOSO.aspx.cs" Inherits="Clinica_Medica.GUARDADO_EXITOSO" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h2>El registro se guardo/modifico exitosamente</h2>
        </div>
        <div>
            <asp:Button ID="btnVolver" runat="server" Text="Menu Principal" OnClick="btnVolver_Click" />
        </div>
    </form>
</body>
</html>
