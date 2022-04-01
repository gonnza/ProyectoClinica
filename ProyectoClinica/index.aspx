<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="ProyectoClinica.clinica" %>

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
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="container-sm " style="margin-top: 5%">
            
            
        <div  class="card border border-4">
            <div class="card-header">
                <h4 >Clinicas</h4>
            </div>
            <div class="card-body">

            <div class="row" >
                <div class="col" >
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          
                           <asp:TextBox ID="txtId" class="form-control " runat="server" Visible="False" >0</asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Razon Social</span>
                           <asp:TextBox ID="razonSocial" class="form-control" runat="server"></asp:TextBox>
                          
                        </div>
                    </div>


                    </div>
                <div class="col" style="margin-top: 1%">
                    
                      <asp:Button ID="btnNuevo" class="btnMed btn btn-primary " type="button" runat="server" Text="Nuevo" />
                     <asp:Button ID="btnGuardar" class="btnMed btn btn-warning" runat="server" Text="Guardar" />
                     <asp:Button ID="btnEliminar" class="btnMed btn btn-danger " runat="server" Text="Eliminar" />
                </div>
               </div>
              </div>
            </div>
            <div class="card border border-4">
                <div class="card-header">
                    <h4>Lista de Clinicas(Seleccionar  clinica para  interactuar)</h4>
                </div>
            
            <div class="card-body">
            <div class="row">
                <div class="col-4 " style="padding-left: 3%">
                    <div class="row">
                        <asp:Button ID="btnPaciente" class=" btn btn-success mb-2" runat="server" Text="Ver pacientes" />
                    </div>
                    <div class="row">
                        <asp:Button ID="btnMedico" class=" btn btn-info mb-2" runat="server" Text="Ver medico" />
                    </div>
                     
                </div>
                <div class="col-8">
                    <asp:GridView ID="gridClinicas"  class="table table-striped border border-primary" runat="server" Width="792px" HorizontalAlign="Center"   >
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" ShowHeader="True" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>  
                </div>
                
               </div>
             </div>
           </div>
        </div>
    </form>
</body>
</html>
<style>
    .data {
        width: 50%;
        
    }
    .btnMed {
        width: 15%;
    }
    .auto-style1 {
        width: 153px;
    }
</style>