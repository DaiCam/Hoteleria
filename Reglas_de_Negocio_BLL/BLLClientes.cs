using Capa_Datos_CD;
using Entidades_de_Negocio_BE;
using System.Collections.Generic;

namespace Reglas_de_Negocio_BLL
{
    public class BLLClientes
    {
        // Declaración de la única instancia permitida de la clase
        private static BLLClientes instance;

        public List<BEClientes> listaClientes = new List<BEClientes>();

        // Constructor privado para evitar la creación de instancias desde fuera de la clase
        private BLLClientes() { }

        // Método estático para obtener la única instancia de la clase
        public static BLLClientes GetInstance()
        {
            if (instance == null)
            {
                instance = new BLLClientes();
            }
            return instance;
        }

        public int AgregarCliente(BEClientes bEClientes) 
        {
            //instancio un objeto de la clase datos para operar con la BD
            Acceso oDatos = new Acceso();
            return oDatos.AltaCliente(bEClientes);
        }

        public List<BEClientes> ObtenerClientes()
        {
            // Instancio un objeto de la clase datos para operar con la BD
            Acceso oDatos = new Acceso();
            // Obtengo la lista de clientes directamente de la base de datos
            listaClientes = oDatos.LeerClientes();
            return listaClientes;
        }

        public List<BEClientes> CargarListaClientes()
        {
            //instancio un objeto de la clase datos para operar con la BD
            Acceso oDatos = new Acceso();
            return oDatos.LeerClientes();
        }

        public string ObtenerDatosCompletos(BEClientes bEClientes)
        {
            return $"{bEClientes.ID_cliente} {bEClientes.Dni} {bEClientes.Nombre} {bEClientes.CuitCuil} {bEClientes.Apellido} {bEClientes.FechaNac} {bEClientes.Telefono} {bEClientes.Localidad} {bEClientes.Direccion} {bEClientes.Nacionalidad} {bEClientes.Correo}";
            
        }

        public int ModificarCliente(BEClientes beClientes)
        {
            Acceso oDatos = new Acceso();
            return oDatos.ModificarClie(beClientes);
        }





    }
}
