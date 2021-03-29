<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cuenta.aspx.cs" Inherits="ClienteWeb.Privado.Cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">
			<a class="logor2" runat="server" href="~/">&copy;</a>
			<a class="btn btn-success menu2" runat="server" href="~/Privado/Cuenta">Mi Cuenta</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Informacion">Información Personal</a>
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
                <h4>Mi Cuenta</h4>
                <div id="fCuenta">
                    <div class="form-group">
                        <label for="txtUsuario">Usuario:</label>
                        <asp:TextBox runat="server" ID="txtUsuario" class="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtCorreo">Correo Seguro:</label>
                        <asp:TextBox runat="server" ID="txtCorreo" type="email" class="form-control" ReadOnly="True"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtSeudonimo">Seudonimo:</label>
                        <asp:TextBox runat="server" ID="txtSeudonimo" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPrivacidad">Privacidad:</label>
                        <asp:TextBox runat="server" ID="txtPrivacidad" type="password" class="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnActualizarCuenta" runat="server" Text="Actualizar" class="btn btn-primary"/>
                </div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
