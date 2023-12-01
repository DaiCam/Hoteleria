using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Capa_Datos_CD;
using Entidades_de_Negocio_BE;

namespace Reglas_de_Negocio_BLL
{
    public class BLLReservas
    {
        private int montoAprox;
       
        // Declaración de la única instancia permitida de la clase
        private static BLLReservas instance;

        public List<BEReservas> listaReservas = new List<BEReservas>();


        // Constructor privado para evitar la creación de instancias desde fuera de la clase
        private BLLReservas() { }

       // Método estático para obtener la única instancia de la clase
       public static BLLReservas GetInstance()
       {
            if (instance == null)
            {
                    instance = new BLLReservas();
            }
           return instance;
       }

       public int AgregarReserva(BEReservas bEReservas) //le paso la clase completa
       {
            Acceso oDatos = new Acceso();
            return oDatos.AltaReserva(bEReservas);
        }

        public List<BEReservas> ObtenerReservas()
        {
            return listaReservas;
        }
       
        public int CalcularMontoPorTipoHabitacion(string tipoHabitacion)
        {
            switch (tipoHabitacion)
            {
                case "Junior":
                    return 100;
                case "Superior":
                    return 150;
                case "Deluxe":
                    return 200;
                default:
                    return 0;
            }
        }

        public int CalcularCantidadDias(DateTime fechaCheckIn, DateTime fechaCheckOut)
        {
            // Verificar que las fechas esten seleccionadas antes de calcular
            if (fechaCheckIn != DateTime.MinValue && fechaCheckOut != DateTime.MinValue)
            {
                TimeSpan diferencia = fechaCheckOut - fechaCheckIn;
                int cantidadDias = diferencia.Days;
                // Calcular la diferencia de días
                return cantidadDias;
            }
            return 0; 
        }

        public int CalcularMontoAprox(int tipoHab, int cantHab, int cantDias) //quiero que me traiga los valores para aca, asi los uso despues
        {
            montoAprox = cantHab * cantDias * tipoHab;
            return montoAprox;
            
        }

        public List<BEReservas> CargarListaReservas()
        {
            //instancio un objeto de la clase datos para operar con la BD
            Acceso oDatos = new Acceso();
            return oDatos.LeerReservas();
        }







    }
}
    

