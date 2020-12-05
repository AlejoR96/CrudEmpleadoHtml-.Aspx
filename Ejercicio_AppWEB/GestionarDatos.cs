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
    
    public class GestionarDatos
    {
        //codigo o atributos para conectar la base de datos 
        public MySqlConnection Conexion;
        public String Error;

        //Constructor De La Clase para Gestionar Datos de la tabla empleados 
        public GestionarDatos()
        {
            this.Conexion = ConexionMysqlEmpleados.GetConnection();
        }

        public List<TbEmpleado> LeerEmpleados()
        {
            List<TbEmpleado> ListaEmpleados = new List<TbEmpleado>();//ObjetoCreado 
            String Sql = "select * from sena2020.empleados";
            MySqlCommand cmd = new MySqlCommand(Sql,Conexion);
            MySqlDataReader Resultado = cmd.ExecuteReader(); 

            while (Resultado.Read())
            {
                TbEmpleado MyEmpleado = new TbEmpleado();
                MyEmpleado.Codigo = Resultado.GetString(1);
                MyEmpleado.Nombre = Resultado.GetString(2);
                MyEmpleado.Apellido = Resultado.GetString(3);
                MyEmpleado.Cargo = Resultado.GetString(4);
                MyEmpleado.Salario = Resultado.GetString(5);
                MyEmpleado.Area = Resultado.GetString(6);
                MyEmpleado.Ciudad = Resultado.GetString(7);
                ListaEmpleados.Add(MyEmpleado);
            }
            Resultado.Close();
            return ListaEmpleados;

        }
        //-----------------------------------------------------------------
           // Verificar si existe o no el codigo del empleado 

        public Boolean ExisteEmpleado(string Codigo)
        {
            string Sql = "select * from empleados where codigo =@codigo";
            MySqlCommand cmd = new MySqlCommand(Sql, Conexion);
            cmd.Parameters.AddWithValue("@codigo", Codigo);
            MySqlDataReader Resultado = cmd.ExecuteReader();
            

            if (Resultado.Read())
            {
                Resultado.Close();
                return true;
            }
            else
            {
                Resultado.Close();
                 return false;

            }

        }




        //-----------------------------------------------------------------

        // Insertar Datos 
        // Crear un Objeto Para Insertar Nuevos Datos a la BD 

        public Boolean InsertarEmpleadoBD(TbEmpleado MyEpleado)
        {
            Boolean Respuesta = false;

            try
            {
                
                string Sql = "insert into empleados (codigo,nombre,apellido,cargo,salario,area,ciudad) values (@Codigo,@nombre,@apellido,@cargo,@salario,@area,@ciudad)";
                MySqlCommand cmd = new MySqlCommand(Sql,Conexion);
                cmd.Parameters.AddWithValue("@Codigo",MyEpleado.Codigo);
                cmd.Parameters.AddWithValue("@nombre", MyEpleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", MyEpleado.Apellido);
                cmd.Parameters.AddWithValue("@cargo", MyEpleado.Cargo);
                cmd.Parameters.AddWithValue("@salario", MyEpleado.Salario);
                cmd.Parameters.AddWithValue("@area", MyEpleado.Area);
                cmd.Parameters.AddWithValue("@ciudad", MyEpleado.Ciudad);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException Excepcion)
            {

                this.Error = Excepcion.Message;
            }
            return Respuesta;
        }

        //-----------------------------------------------------------------

        //Traer un empleado al formulario

        public TbEmpleado consultaEmpleadoBD(string Codigo)
        {
            
            String Sql = "select * from sena2020.empleados where codigo=@codigo";
            MySqlCommand cmd = new MySqlCommand(Sql, Conexion);
            cmd.Parameters.AddWithValue("@Codigo",Codigo);
            MySqlDataReader Resultado = cmd.ExecuteReader();

            if(Resultado.Read())
            {
                TbEmpleado MyEmpleado = new TbEmpleado();
                MyEmpleado.Codigo = Resultado.GetString(1);
                MyEmpleado.Nombre = Resultado.GetString(2);
                MyEmpleado.Apellido = Resultado.GetString(3);
                MyEmpleado.Cargo = Resultado.GetString(4);
                MyEmpleado.Salario = Resultado.GetString(5);
                MyEmpleado.Area = Resultado.GetString(6);
                MyEmpleado.Ciudad = Resultado.GetString(7);
                Resultado.Close();
                return MyEmpleado;
            }
            else
            {
                Resultado.Close();
                return null;
            }
           


        }

        //-----------------------------------------------------------------

        //Editar los Datos de un empleado 

        public Boolean EditarEmpleadoBD(TbEmpleado MyEpleado)
        {
            Boolean Respuesta = false;

            try
            {

                string Sql = "update sena2020.empleados set nombre=@nombre,apellido=@apellido,cargo=@cargo,salario=@salario,area=@area,ciudad=@ciudad  where codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(Sql, Conexion);
                cmd.Parameters.AddWithValue("@codigo", MyEpleado.Codigo);
                cmd.Parameters.AddWithValue("@nombre", MyEpleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", MyEpleado.Apellido);
                cmd.Parameters.AddWithValue("@cargo", MyEpleado.Cargo);
                cmd.Parameters.AddWithValue("@salario", MyEpleado.Salario);
                cmd.Parameters.AddWithValue("@area", MyEpleado.Area);
                cmd.Parameters.AddWithValue("@ciudad", MyEpleado.Ciudad);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException Excepcion)
            {

                this.Error = Excepcion.Message;
            }
            return Respuesta;
        }


        //-----------------------------------------------------------------

        //Borrar los Datos de un empleado 

        public Boolean EliminarEmpleadoBD(string Codigo)
        {
            Boolean Respuesta = false;

            try
            {

                string Sql = "delete from sena2020.empleados  where codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(Sql, Conexion);
                cmd.Parameters.AddWithValue("@codigo",Codigo);
                
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException Excepcion)
            {

                this.Error = Excepcion.Message;
            }
            return Respuesta;
        }

    }
}