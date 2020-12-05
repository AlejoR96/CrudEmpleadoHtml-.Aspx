using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_AppWEB
{
    //Clase de la Base de Datos con su tabla Empleados 
    public class TbEmpleado
    {
        // Inicio de Informacion de la tabla Empleados 
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cargo  { get; set; }

        public string Salario { get; set; }

        public string Area  { get; set; }

        public string Ciudad { get; set; }
        // Fin de Informacion de la tabla Empleados 


    }
}