using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_de_Negocio_BE
{
    public class BEReservas
    {
        public int Cod_reserva { get; set; }
        public int ID_cliente { get; set; }
        public int Cant_noches { get; set; }
        public int Cant_habitaciones { get; set; }
        public int Cant_adultos { get; set; } //separar adultos de menores
        public int Cant_menores { get; set; }
        public string Tipo_habitacion { get; set; }
        public DateTime Check_in { get; set; }
        public DateTime Check_out { get; set; }
        public string Tipo_cama { get; set; }
        public int Monto_aproximado { get; set; }



        //constructor 
        public BEReservas() { }

        public BEReservas(int codReserva, int idCliente, int cantNoches, int cantHabitaciones,
                   int cantAdultos, int cantMenores, string tipoHabitacion,
                   DateTime checkIn, DateTime checkOut, string tipoCama, int montoAproximado)
        {
            Cod_reserva = codReserva;
            ID_cliente = idCliente;
            Cant_noches = cantNoches;
            Cant_habitaciones = cantHabitaciones;
            Cant_adultos = cantAdultos;
            Cant_menores = cantMenores;
            Tipo_habitacion = tipoHabitacion;
            Check_in = checkIn;
            Check_out = checkOut;
            Tipo_cama = tipoCama;
            Monto_aproximado = montoAproximado;
        }
    }
}
