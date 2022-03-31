﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="medico.aspx.vb" Inherits="ProyectoClinica.medico" %>

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
        
        <div class="container-sm border border-primary border-5" style="margin-top: 5%">
            

            <div class="row">
                <div class="col">
                    <h4 style="margin-left: 40%">Datos de Médico</h4>
                </div>
            </div>

            <div class="row" >
                <div class="col" >
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          
                           <asp:TextBox ID="txtId" class="form-control " runat="server" Visible="False" >0</asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Nombre</span>
                           <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                          
                        </div>
                    </div>

                     <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Nro de Matricula</span>
                           <asp:TextBox ID="txtNroMatricula" class="form-control" runat="server"></asp:TextBox>
                          
                        </div>
                    </div>

                     <div class="row">
                        <div class=" data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Especialidad</span>&nbsp;
                          <asp:DropDownList ID="selectEspecialidad" CssClass="form-select" runat="server">
                              <asp:ListItem>Cirujano</asp:ListItem>
                              <asp:ListItem>Dentista</asp:ListItem>
                              <asp:ListItem>Terapeuta</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    
                    </div>
                <div class="col">
                    <div class="row mt-3">
                        <asp:Button ID="btnNuevo" class="btnMed btn btn-primary mb-2" type="button" runat="server" Text="Nuevo" />
                    </div>
                    <div class="row">
                        <asp:Button ID="btnGuardar" class="btnMed btn btn-warning mb-2" runat="server" Text="Guardar" />
                    </div>
                    <div class="row">
                        <asp:Button ID="btnEliminar" class="btnMed btn btn-danger mb-2" runat="server" Text="Eliminar" />
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <h4 style="margin-left: 40%">Lista de Médicos</h4>
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <asp:GridView ID="gridMedicos"  class="table table-striped border border-primary" runat="server" Width="792px" HorizontalAlign="Center"   >
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Select Row" ShowHeader="True" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>  
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