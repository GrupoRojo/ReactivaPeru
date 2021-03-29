<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estudios.aspx.cs" Inherits="ClienteWeb.Privado.Estudios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">
			<a class="logor2" runat="server" href="~/">&copy;</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Cuenta">Mi Cuenta</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Informacion">Información Personal</a>
			<a class="btn btn-success menu2" runat="server" href="~/Privado/Estudios">Formación Profesional</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Trabajo">Experiencia Laboral</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Habilidad">Mis Habilidades</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Telefono">Celular y/o Teléfono</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Correo">Correos Electrónicos</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/RedesSociales">Redes Sociales</a>
		</div>
		<div class="col-md-8">
			<div class="titulo">
				<h3>
					Sistema de información para la administración de CV <p>para REACTIVA PERÚ</p>
				</h3>
			</div>
			<div class="info">
				<div class="container-fluid">
					<div class="row">
						<div class="col-md-9">
							<asp:LoginName ID="LoginName2" runat="server" />
						</div>
						<div class="col-md-3">
							<asp:LoginStatus ID="LoginStatus2" runat="server" class="btn btn-success" />
						</div>
					</div>
				</div>
			</div>
			<div class="info">
                <h4>Formación Profesional</h4>
                <div id="fEstudio">
                    <div class="form-group">
                        <label for="txtCodEstudio">CodEstudio:</label>
                        <asp:TextBox runat="server" ID="TextCodEstudio" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtVision">Vision:(Visible:V Privado:P Oculto:O)</label>
                        <asp:TextBox runat="server" ID="txtVision" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtIntitucion">Intitucion:</label>
                        <asp:TextBox runat="server" ID="txtIntitucion" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtFacultad">Facultad:</label>
                        <asp:TextBox runat="server" ID="txtFacultad" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtCarrera">Carrera:</label>
                        <asp:TextBox runat="server" ID="txtCarrera" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtInicio">Inicio:</label>
                        <asp:TextBox runat="server" ID="txtinicio" class="form-control"></asp:TextBox>
                                
                        <asp:CheckBox ID="chekFin" runat="server" Text="Habilitar para cambiar Fecha" />

                        <asp:Calendar ID="calendario" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="txtFin">Fin:</label>
                        <asp:TextBox runat="server" ID="txtFin" class="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="BtnAgregarEstudio" runat="server" Text="Agregar" class="btn btn-primary"/>
                    <asp:Button ID="BtnEliminarEstudio" runat="server" Text="Eliminar" class="btn btn-primary"/>
                    <asp:Button ID="btnActualizarCuenta" runat="server" Text="Actualizar" class="btn btn-primary"/>
                </div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
