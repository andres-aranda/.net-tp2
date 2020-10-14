<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaNoPermitida2.aspx.cs" Inherits="Academia.UI.Web.PaginaNoPermitida2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Styles/no-permitido.css" />
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="containerNoPermitido">
          <p>Ups! No tienes permitido el acceso a esta pagina 
              <br />
              <br />
              <a href="Login.aspx">Volver a Inicio</a></p>
          <img src="Resources/alto.gif" alt="Sample Photo" />
        </div>
        
    </form>
</body>
</html>
