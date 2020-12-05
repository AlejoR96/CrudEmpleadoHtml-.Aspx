using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Librerias de conexión a Mysql
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;


namespace Ejercicio_AppWEB
{
    //clase de Conexion a Mysql
    public class ConexionMysqlEmpleados
    {
       // Inicio de creacion de conexion a la base de datos 

        private static MySqlConnection ObjConexionBD; //Esto Es Un Objeto de Conexion a Mysql

        private static String Error;

        public static MySqlConnection GetConnection()
        {
            if (ObjConexionBD != null)
                return ObjConexionBD;

            //Crear la cadena de conexion a Base de Datos
            ObjConexionBD = new MySqlConnection("Server=localhost;Database=sena2020;Uid=UserSena;Pwd=sena2020;");

            try
            {
                //Abre la conexion Base de Datos 
                ObjConexionBD.Open();
                return ObjConexionBD;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return null;
            }
            
        }

        public static void CerrarConexion()
        {
            // Cierra la conexion  Base de Datos 
            if (ObjConexionBD != null)
                ObjConexionBD.Close();
        }

    }
}