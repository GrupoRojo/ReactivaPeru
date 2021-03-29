<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Telefono.aspx.cs" Inherits="ClienteWeb.Privado.Telefono" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">
			<a class="logor2" runat="server" href="~/">&copy;</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Cuenta">Mi Cuenta</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Informacion">Información Personal</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Estudios">Formación Profesional</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Trabajo">Experiencia Laboral</a>
			<a class="btn btn-success menu1" runat="server" href="~/Privado/Habilidad">Mis Habilidades</a>
			<a class="btn btn-success menu2" runat="server" href="~/Privado/Telefono">Celular y/o Teléfono</a>
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
                <h4>Celular y/o Teléfono</h4>
                <div id="fFono">
                    <div class="form-group">
                        <label for="txtCodFono">CodigoFono:</label>
                        <asp:TextBox runat="server" ID="txtCodFono" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtVision">Vision:(Visible:V Privado:P Oculto:O)</label>
                        <asp:TextBox runat="server" ID="txtVision" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtTipo">Tipo:</label>
                        <asp:TextBox runat="server" ID="txtTipo" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtNumero">Numero:</label>
                        <asp:TextBox runat="server" ID="txtNumero" class="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="BtnAgregarTelefono" runat="server" Text="Agregar" class="btn btn-primary"/>
                    <asp:Button ID="btnEliminarTelefono" runat="server" Text="Eliminar" class="btn btn-primary"/>
                    <asp:Button ID="btnActualizarTelefono" runat="server" Text="Actualizar" class="btn btn-primary"/>
                </div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
