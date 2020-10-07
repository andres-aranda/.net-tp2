<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Academia.UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Academia</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@100;300;400;500;700;900&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Zilla+Slab:wght@400;500;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="Styles/login-styles.css" />
</head>
<body class="h-100">
    <form class="h-100" id="form1" runat="server">
        <div>
        </div>
        <div class="container-fluid h-100">
            <div class="row h-100 d-flex justify-content-center align-items-center">
                <div class="col"></div>
                <div class="col-3">
                <h1>Ingresar</h1>
                    <div class="card form-sheet">
                        <asp:Panel ID="panel" runat="server" >
                            <asp:TextBox TextMode="SingleLine" class="form-control" ID="txtUsuario" placeholder="Nombre de usuario" runat="server"></asp:TextBox>
                            <asp:TextBox TextMode="Password" class="form-control" ID="txtContraseña" placeholder="Contraseña" runat="server"></asp:TextBox>
                            <asp:Button class="btn btn-primary float-right" ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                        </asp:Panel>
                    </div>
                </div>
                <div class="col"></div>
            </div>
        </div>
    </form>
</bod>
</html>
