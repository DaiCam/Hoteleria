using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_de_Negocio_BE
{
    public class BEClientes
    {
        public int ID_cliente { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string CuitCuil { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public int Telefono { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }
        public string Correo { get; set; }



        //Constructores
        public BEClientes() { }

        public BEClientes(int dni, string nombre, string cuitCuil, string apellido, string fechaNac, string nacionalidad, string direccion, string localidad, int telefono, string correo)
        {
            Dni = dni;
            Nombre = nombre;
            CuitCuil = cuitCuil;
            Apellido = apellido;
            FechaNac = fechaNac;
            Telefono = telefono;
            Localidad = localidad;
            Direccion = direccion;
            Nacionalidad = nacionalidad;
            Correo = correo;
        }
    }   

}
