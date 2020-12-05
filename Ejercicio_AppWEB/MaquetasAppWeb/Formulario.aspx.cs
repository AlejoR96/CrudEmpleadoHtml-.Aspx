using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_AppWEB.MaquetasAppWeb
{
    public partial class Fomulario : System.Web.UI.Page
    {
        ValidarCajasFormulario ValidarCajas = new ValidarCajasFormulario();
        GestionarDatos DatosBD = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Carga el formulario una vez 
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    Txtcodigo.Text = Request.QueryString["id"];
                    TbEmpleado MyEmpleado = DatosBD.consultaEmpleadoBD(Txtcodigo.Text);
                    TxtNombre.Text = MyEmpleado.Nombre;
                    TxtApellido.Text = MyEmpleado.Apellido;
                    TxtCargo.Text = MyEmpleado.Cargo;
                    TxtSalario.Text = MyEmpleado.Salario;
                    TxtArea.Text = MyEmpleado.Area;
                    TxtCiudad.Text = MyEmpleado.Ciudad;
                    BtnAgregarEmpleado.Visible = false;
                    BtnEditarEmpleado.Visible = true;
                    BtnBorrarEmpleado.Visible = true;
                    Txtcodigo.Enabled = false;
                }
                else
                {
                    Txtcodigo.Enabled = true;
                    BtnAgregarEmpleado.Visible = true;
                    BtnEditarEmpleado.Visible = false;
                    BtnBorrarEmpleado.Visible = false;
                    return;
                }

            }

        }

        protected void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            // Enviar Datos 

            if (!ValidarCajas.Vacio(Txtcodigo, LblErrorCodigo, "No puede estar vacio"))
                if(!ValidarCajas.Vacio(TxtNombre, LblErrorNombre, "No puede estar vacio"))
                    if(!ValidarCajas.Vacio(TxtApellido, LblErrorApellido, "No puede estar vacio"))
                       if(!ValidarCajas.Vacio(TxtCargo, LblErrorCargo, "No puede estar vacio"))
                          if(!ValidarCajas.Vacio(TxtSalario, LblErrorSalario, "No puede estar vacio"))
                               if(!ValidarCajas.Vacio(TxtArea, LblErrorArea, "No puede estar vacio"))
                                   if(!ValidarCajas.Vacio(TxtCiudad, LblErrorCiudad, "No puede estar vacio"))
                                   {
                                        InsertarDatosBD();
                                        LimpiarCajas();
                                   }



        }

        private void InsertarDatosBD()
        {
            TbEmpleado MyEmpleado = new TbEmpleado();
            MyEmpleado.Codigo = Txtcodigo.Text;
            MyEmpleado.Codigo = TxtNombre.Text;
            MyEmpleado.Codigo = TxtApellido.Text;
            MyEmpleado.Codigo = TxtCargo.Text;
            MyEmpleado.Codigo = TxtSalario.Text;
            MyEmpleado.Codigo = TxtArea.Text;
            MyEmpleado.Codigo = TxtCiudad.Text;

            if(DatosBD.ExisteEmpleado(Txtcodigo.Text))
            {
                if (DatosBD.InsertarEmpleadoBD(MyEmpleado))
                {
                    Lblrespuesta.Text = "!!! Registro Exitoso ¡¡¡";

                }
                else
                {
                    Lblrespuesta.Text = "Error Al Ingresar Datos" + DatosBD.Error;
                }

            }
            else
            {
                Lblrespuesta.Text = "El Codigo Ya Existe" + Txtcodigo.Text;

            }



        }

        private void LimpiarCajas()
        {
            Txtcodigo.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCargo.Text = "";
            TxtSalario.Text = "";
            TxtArea.Text = "";
            TxtNombre.Text = "";
            TxtCiudad.Text = "";
            Txtcodigo.Focus();
        }

        protected void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            //Codigo para editar al empleado 
            TbEmpleado MyEmpleado = new TbEmpleado();
            MyEmpleado.Codigo = Txtcodigo.Text;
            MyEmpleado.Nombre = TxtNombre.Text;
            MyEmpleado.Apellido = TxtApellido.Text;
            MyEmpleado.Cargo = TxtCargo.Text;
            MyEmpleado.Salario = TxtSalario.Text;
            MyEmpleado.Area = TxtArea.Text;
            MyEmpleado.Ciudad = TxtCiudad.Text;

            if (DatosBD.EditarEmpleadoBD(MyEmpleado))
            {
                Lblrespuesta.Text = "El Registro Fue Actualizado Correctamente";
            }
            else
            {
                Lblrespuesta.Text = "Error al actualizar" + DatosBD.Error;
            }
        }

        protected void BtnBorrarEmpleado_Click(object sender, EventArgs e)
        {

            //Codigo para borrar el empleado

                    
       
            if (DatosBD.EliminarEmpleadoBD(Txtcodigo.Text))
            {
                Lblrespuesta.Text = "El Empleado fue Borrado Correctamente";
                LimpiarCajas();
            }
            else
            {
                Lblrespuesta.Text = "Error al Borrar" + DatosBD.Error;
            }


        }
    }
}