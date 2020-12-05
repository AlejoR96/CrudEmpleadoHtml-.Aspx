<%@ Page Title="" Language="C#" MasterPageFile="~/MaquetasAppWeb/MasterPage.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="Ejercicio_AppWEB.MaquetasAppWeb.Datos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!---Inicio Datos--->
    <h1 class="TextH1">CRUD Basico a una tabla BD html</h1>

     <div class="ContenedorBtnBD">

            <div>
                <asp:Button ID="BtnListaEmpleado" runat="server" OnClick="BtnListaEm_Click" Text="Lista Empleados" CssClass="BtnMenu" />
            </div>

            <div>
                <asp:TextBox ID="TxtcodigoBuscar" runat="server"></asp:TextBox>
            </div>

            <div>
                <asp:Button ID="BtnBuscarEmpleado" runat="server" OnClick="BtnBuscarEmpleado_Click" Text="Buscar Empleado" CssClass="BtnMenu" />
            </div>

            <div>
                <asp:Label ID="LblRtaBuscar" runat="server"></asp:Label>
            </div>

        </div>


    <main class="EstiloMain">

       



        <div class="ContenedorDatos">
            <!--- Aqui va la lista empleado-->

            <div class="ContenedorGrivEmpleados">
                <asp:GridView CssClass="FormatoGriv" ID="gvEmpleados" runat="server" Height="200px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" AllowPaging="True" OnPageIndexChanging="gvEmpleados_PageIndexChanging" DataKeyNames="Codigo" OnRowCommand="gvEmpleados_RowCommand">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
            </div>
        </div>
    </main>
    <!---Fin Datos--->

</asp:Content>
