<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Informacion.aspx.cs" Inherits="ClienteWeb.Privado.Informacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">
			<a class="logor2" runat="server" href="~/">&copy;</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Cuenta">Mi Cuenta</a>
			<a class="btn btn-success menu2" runat="server" href="~/Privado/Informacion">Información Personal</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Estudios">Formación Profesional</a>
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
                <h4>Información Personal</h4>
                <div id="fDato">
                    <div class="form-group">
                        <label for="txtApellidos">Apellidos:</label>
                        <asp:TextBox runat="server" ID="txtApellidos" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtNombres">Nombres:</label>
                        <asp:TextBox runat="server" ID="txtNombres" class="form-control"></asp:TextBox>
                    </div>
                    <!-- Fecha de Nacimiento -->
                    <div class="form-group">
                        <label for="txtNacimiento">Nacimiento:</label>
                        <asp:TextBox runat="server" ID="txtNacimiento" class="form-control"></asp:TextBox>
                        <asp:Calendar ID="Calendario" runat="server"></asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="txtDNI">DNI:</label>
                        <asp:TextBox runat="server" ID="txtDNI" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtDireccion">Direccion:</label>
                        <asp:TextBox runat="server" ID="txtDireccion" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtInformacion">Informacion:</label>
                        <asp:TextBox runat="server" ID="txtInformacion" class="form-control" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <!-- Botones -->
                    <div class="form-group">
                    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" class="btn btn-primary"/>
                    </div>
                </div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
