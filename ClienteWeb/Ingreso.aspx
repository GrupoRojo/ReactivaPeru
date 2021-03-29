<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingreso.aspx.cs" Inherits="ClienteWeb.Ingreso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

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
                <p><b>Ingreso</b></p>
                <hr />
				<asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate"></asp:Login>
			</div>
		</div>
	</div>
</div>

</asp:Content>
