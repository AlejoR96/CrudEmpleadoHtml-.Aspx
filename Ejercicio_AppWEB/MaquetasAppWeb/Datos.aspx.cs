using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_AppWEB.MaquetasAppWeb
{
    public partial class Datos : System.Web.UI.Page
    {
        // Crear un objeto en donde gestiona los datos 

        GestionarDatos datos = new GestionarDatos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Invocamos la lista list<> con el objeto de la lista empleados

                List<TbEmpleado> ListaEmpleados = datos.LeerEmpleados();

                // Ahora debemos mostrar la lista Empleados en datagridview

                gvEmpleados.DataSource = ListaEmpleados;
                gvEmpleados.DataBind();

            }

        }

        protected void BtnListaEm_Click(object sender, EventArgs e)
        {

            // Invocamos la lista list<> con el objeto de la lista empleados

            List<TbEmpleado> ListaEmpleados = datos.LeerEmpleados();

            // Ahora debemos mostrar la lista Empleados en datagridview

            gvEmpleados.DataSource = ListaEmpleados;
            gvEmpleados.DataBind();

        }



        protected void gvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmpleados.PageIndex = e.NewPageIndex;
            List<TbEmpleado> ListaEmpleados = datos.LeerEmpleados();
            gvEmpleados.DataSource = ListaEmpleados;
            gvEmpleados.DataBind();
        }

        protected void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (datos.ExisteEmpleado(TxtcodigoBuscar.Text))
            {
                Response.Redirect("Formulario.aspx?id=" + TxtcodigoBuscar.Text);

            }
            else
            {
                LblRtaBuscar.Text = "No existe codigo en la BD";
            }
        }

        protected void gvEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                string valor = Convert.ToString(gvEmpleados.DataKeys[indice].Value);
                //Response.Write("Valor de Fila" + indice);
                //Response.Write("Valor de Celda" + valor);
                Response.Redirect("Formulario.aspx?id=" + valor);

            }
        }
    }
}