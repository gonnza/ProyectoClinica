<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consulta.aspx.vb" Inherits="ProyectoClinica.WebForm1" %>

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
                    <h4 style="margin-left: 45%;">Consulta</h4>
                </div>
            </div>

            <div class="row" >
                <div class="col mt-1 " style="margin-right: 2%;">
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          
                           <asp:TextBox ID="txtId" class="form-control " runat="server" Visible="False" >0</asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Descripcion</span>
                           <asp:TextBox ID="txtDescripcion" class="form-control" runat="server"></asp:TextBox>
                          
                        </div>
                    </div>

                     

                     <div class="row">
                        <div class=" data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Tipo de Consulta</span>&nbsp;
                          <asp:DropDownList ID="selectTipoConsulta" CssClass="form-select" runat="server">
                              <asp:ListItem>Consulta</asp:ListItem>
                              <asp:ListItem>Práctica médica</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Costo</span>
                           <asp:TextBox ID="txtCosto" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Costo de Práctica</span>
                           <asp:TextBox ID="txtCostoPractica" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Nro de historia clinica de paciente</span>
                           <asp:TextBox ID="nroHistoriaClinica" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="data input-group input-group-sm mb-3" style="margin-left: 40%">
                          <span class="input-group-text" >Nro de Matricula de medico asignado</span>
                           <asp:TextBox ID="nroMatricula" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="row mt-3">
                        <p>Seleccione fecha:</p>
                    </div>
                    <div class="row">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                                 <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                 <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                 <OtherMonthDayStyle ForeColor="#999999" />
                                 <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                 <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                 <TodayDayStyle BackColor="#CCCCCC" />
                             </asp:Calendar>

                    </div>
                </div>
            </div>
            <div class="row">
                
                <div class="col" style="padding-left: 30%;">

                        <asp:Button ID="btnNuevo" class="btnMed btn btn-primary mb-2" type="button" runat="server" Text="Nuevo" />
                    
                        <asp:Button ID="btnGuardar" class="btnMed btn btn-warning mb-2" runat="server" Text="Guardar" />
                    
                        <asp:Button ID="btnEliminar" class="btnMed btn btn-danger mb-2" runat="server" Text="Eliminar" />
                    </div>
            </div>

            <div class="row">
                <div class="col">
                    <h4 style="margin-left: 40%">Lista de Consultas</h4>
                </div>
            </div>

            <div class="row">
                <div class="col">
                    <asp:GridView ID="gridConsultas"  class="table table-striped border border-primary" runat="server" Width="792px" HorizontalAlign="Center"   >
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
        width: 60%;
        
    }
    .btnMed {
        width: 15%;
    }
    </style>
