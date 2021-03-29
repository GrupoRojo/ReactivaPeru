<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClienteWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="container-fluid">
	<div class="row">
		<div class="col-md-4">
			<a class="logor" runat="server" href="~/">&copy;</a>
		</div>
		<div class="col-md-8">
			<div class="titulo">
				<h3>
					Sistema de información para la administración de CV <p>para REACTIVA PERÚ</p>
				</h3>
			</div>
			<div class="info">
                <p><b>Bienvenido</b></p>
					<p>Bienvenido a la pagina web del Grupo Rojo, en colaboración con Reactiva Perú.</p>
					<p>Puedes ingresar o registrarte para administrar tu Curriculum Vitae Profesional.</p>
                <hr />
				<a class="boton" runat="server" href="~/Registro">Registro</a>
				<a class="boton" runat="server" href="~/Ingreso">Ingreso</a>
			</div>
		</div>
	</div>
</div>

</asp:Content>
