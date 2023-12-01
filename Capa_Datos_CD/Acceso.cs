using Entidades_de_Negocio_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_CD
{
    public class Acceso
    {
        //declaro el objeto del tipo conection
        private SqlConnection conexion;

        //creo el metodo abrir, le paso la cadena de conexion para saber la direccion de la BD y la abro con la propiedad Open
        public void Abrir()
        {
            conexion = new SqlConnection();

            //le paso el conectionstring para saber a que BD me voy a conectar
            conexion.ConnectionString = Conexion.cadena;
            conexion.Open();
        }

        //creo el metodo cerrar la conexion y limpio la misma de memoria con el Dispose
        public void Cerrar()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        public List<BEClientes> LeerClientes()
        {
            //instancio la lista de clientes
            List<BEClientes> listaClientes = new List<BEClientes>();
            //abro la conexion
            Abrir();
            //instancio el objeto command
            SqlCommand cmd = new SqlCommand();
            //envio la consulta
            cmd.CommandText = "select ID_cliente, Dni_cliente, Nombre_cliente, Cuit_cuil, Apellido_cliente, Fecha_nacimiento, Telefono, Localidad, Direccion, Nacionalidad, Correo from CLIENTE";
            cmd.Connection = conexion;
            //instancio el objeto lector del tipo datareader
            SqlDataReader lector = cmd.ExecuteReader();
            //recorro toda la tabla y por cada registro creo un objeto del tipo cliente y lo agrego a la lista
            while(lector.Read())
            {
                BEClientes oCliente = new BEClientes();

                oCliente.ID_cliente = Convert.ToInt32(lector[0]);
                oCliente.Dni = Convert.ToInt32(lector[1]);
                oCliente.Nombre = lector[2].ToString();
                oCliente.CuitCuil = lector[3].ToString();
                oCliente.Apellido = lector[4].ToString();
                oCliente.FechaNac = lector[5].ToString();
                object telefono = lector[6];
                oCliente.Telefono = telefono != DBNull.Value ? Convert.ToInt32(telefono) : 0; //establecer el valor por defecto
                oCliente.Localidad = lector[7].ToString();
                oCliente.Direccion = lector[8].ToString();
                oCliente.Nacionalidad = lector[9].ToString();
                oCliente.Correo = lector[10].ToString();
                listaClientes.Add(oCliente);
            }
            //cierro la conexion del datareader
            lector.Close();
            //cierro la conexion a la BD
            Cerrar();
            //devuelvo la lista
            return listaClientes;
        }

        public int AltaCliente(BEClientes bEClientes)
        {
            int filasAfectadas = 0;
            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO CLIENTE (Dni_cliente, Nombre_cliente, Cuit_cuil, Apellido_cliente, Fecha_nacimiento, Telefono, Localidad, Direccion, Nacionalidad, Correo) VALUES ('" + bEClientes.Dni + "', '" + bEClientes.Nombre + "', '" + bEClientes.CuitCuil + "', '" + bEClientes.Apellido + "', '" + bEClientes.FechaNac + "', '" + bEClientes.Telefono + "', '" + bEClientes.Localidad + "', '" + bEClientes.Direccion + "', '" + bEClientes.Nacionalidad + "', '" + bEClientes.Correo + "')";

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            
            }
            catch (SqlException ex)
            {
                filasAfectadas = -1;
                throw ex;
            }
            Cerrar();
            return filasAfectadas;
           
        }

        public int AltaReserva(BEReservas bEReservas)
        {
            int filasAfectadas = 0;
            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO RESERVA (Id_cliente, Cant_noches, Cant_habitaciones, Cant_adultos, Cant_menores, Tipo_habitacion, Check_in, Check_out, Tipo_cama, Monto_aproximado) VALUES ('" + bEReservas.ID_cliente + "', '" + bEReservas.Cant_noches + "', '" + bEReservas.Cant_habitaciones + "', '" + bEReservas.Cant_adultos + "', '" + bEReservas.Cant_menores + "', '" + bEReservas.Tipo_habitacion + "', '" + bEReservas.Check_in + "', '" + bEReservas.Check_out + "', '" + bEReservas.Tipo_cama + "', '" + bEReservas.Monto_aproximado + "')";

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                filasAfectadas = -1;
                throw ex;
            }
            Cerrar();
            return filasAfectadas;

        }

        public List<BEReservas> LeerReservas()
        {
            // Instancio la lista de reservas
            List<BEReservas> listaReservas = new List<BEReservas>();
            // Abro la conexión
            Abrir();
            // Instancio el objeto command
            SqlCommand cmd = new SqlCommand();
            // Envío la consulta
            cmd.CommandText = "SELECT Cod_reserva, ID_cliente, Cant_noches, Cant_habitaciones, Cant_adultos, Cant_menores, Tipo_habitacion, Check_in, Check_out, Tipo_cama, Monto_aproximado FROM RESERVA";
            cmd.Connection = conexion;
            // Instancio el objeto lector del tipo datareader
            SqlDataReader lector = cmd.ExecuteReader();
            // Recorro toda la tabla y por cada registro creo un objeto del tipo reserva y lo agrego a la lista
            while (lector.Read())
            {
                BEReservas oReserva = new BEReservas();

                oReserva.Cod_reserva = Convert.ToInt32(lector["Cod_reserva"]);
                oReserva.ID_cliente = Convert.ToInt32(lector["ID_cliente"]);
                oReserva.Cant_noches = Convert.ToInt32(lector["Cant_noches"]);
                oReserva.Cant_habitaciones = Convert.ToInt32(lector["Cant_habitaciones"]);
                oReserva.Cant_adultos= Convert.ToInt32(lector["Cant_adultos"]);
                oReserva.Cant_menores = Convert.ToInt32(lector["Cant_menores"]);
                oReserva.Tipo_habitacion = lector["Tipo_habitacion"].ToString();
                oReserva.Check_in = (DateTime)lector["Check_in"];
                oReserva.Check_out = (DateTime)lector["Check_out"];
                oReserva.Tipo_cama = lector["Tipo_cama"].ToString();
                oReserva.Monto_aproximado = Convert.ToInt32(lector["Monto_aproximado"]);

                listaReservas.Add(oReserva);
            }
            // Cierro la conexión del datareader
            lector.Close();
            // Cierro la conexión a la BD
            Cerrar();
            // Devuelvo la lista
            return listaReservas;
        }

        public int ModificarClie(BEClientes beClientes)
        {
            int filasAfectadas = 0;
            Abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexion;
            cmd.CommandText = "UPDATE CLIENTE SET Nombre = '" + beClientes.Nombre + "', Telefono = '" + beClientes.Telefono + "', Localidad = '" + beClientes.Localidad + "', Direccion = '" + beClientes.Direccion + "', Correo = '" + beClientes.Correo + "' WHERE ID_cliente = " + beClientes.ID_cliente;

            try
            {
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                filasAfectadas = -1;
                throw ex;
            }
            Cerrar();
            return filasAfectadas;
        }
        

    }
}
