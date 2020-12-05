<%@ Page Title="" Language="C#" MasterPageFile="~/MaquetasAppWeb/MasterPage.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Ejercicio_AppWEB.MaquetasAppWeb.Fomulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!---Inicio nombre de cabecera Formulario--->
    <h1 class="TextH1">CRUD FORMULARIO </h1>
    <!---Final nombre de cabecera Formulario--->


    <main class="EstiloMain">

        <div class="ContenedorBtnBD">
            <asp:Label ID="Lblrespuesta" runat="server"></asp:Label>
            &nbsp;
        </div>

        <div class="ContenedorDatos">
            <!---Inicio contenedor de los datos-->

            <div class="ContenedorTodoform">
                <!--- Inicio codigo de las cajas de Textbox Formulario-->

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblCodigo" runat="server" Text="Codigo"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="Txtcodigo" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorCodigo" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>


                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblNombre" runat="server" Text="Nombre"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorNombre" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblApellido" runat="server" Text="Apellido"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtApellido" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorApellido" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblCargo" runat="server" Text="Cargo"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtCargo" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorCargo" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LbSalario" runat="server" Text="Salario"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtSalario" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorSalario" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblArea" runat="server" Text="Area"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtArea" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorArea" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorDatoForm">
                    <!--- Inicio Informacion de tabla Empleados-->
                    <div class="ContenedorLabel">
                        <asp:Label ID="LblCiudad" runat="server" Text="Ciudad"></asp:Label></div>
                    <div class="ContenedorTxtbox">
                        <asp:TextBox ID="TxtCiudad" runat="server"></asp:TextBox></div>
                    <div class="ContenedorError">
                        <asp:Label ID="LblErrorCiudad" runat="server" Text="---" Font-Size="Smaller" ForeColor="Red"></asp:Label></div>
                    <!--- Fin Informacion De Tabla Empleados-->
                </div>

                <div class="ContenedorBtnBD">
                    <asp:Button ID="BtnAgregarEmpleado" runat="server" Text="Enviar Datos" class="btnApp" OnClick="BtnAgregarEmpleado_Click" CssClass="BtnMenu"/>

                    <asp:Button ID="BtnEditarEmpleado" runat="server" Text="Guardar Datos" class="btnApp" OnClick="BtnEditarEmpleado_Click" CssClass="BtnMenu"/>

                    <asp:Button ID="BtnBorrarEmpleado" runat="server" Text="Borrar Datos" class="btnApp" OnClick="BtnBorrarEmpleado_Click" OnClientClick="if(!confirm('Desea borra el registro?')) return false;" CssClass="BtnMenu"/>
                </div>

                <!--- Final codigo de las cajas de Textbox Formulario-->
            </div>
        </div>
        <!---Fin contenedor de los datos--->
    </main>

</asp:Content>
