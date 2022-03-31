<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="ProyectoClinica.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Required meta tags -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-sm">
           
            <div class="mb-3">
              
                <asp:Button class="btn btn-primary" ID="btnConsulta" runat="server"  Text="Consulta" />
                <asp:Button class="btn btn-primary" ID="btnMedico" runat="server" PostBackUrl = "~/medico.aspx" Text="Medico" />
                <asp:Button class="btn btn-primary" ID="btnPaciente" runat="server"  PostBackUrl = "~/paciente.aspx" Text="Paciente" />
            </div>
        </div>
    </form>
</body>
</html>
