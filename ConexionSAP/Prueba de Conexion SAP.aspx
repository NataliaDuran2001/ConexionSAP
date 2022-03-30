<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba de Conexion SAP.aspx.cs" Inherits="ConexionSAP.Prueba_de_Conexion_SAP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
      
            <asp:Label runat="server" ID="Linfo" Visible="false"></asp:Label>

            <asp:Button runat="server" ID="BtnConexion" Text="Conectar" OnClick="BtnConexion_Click" />
        </div>
    </form>
</body>
</html>
