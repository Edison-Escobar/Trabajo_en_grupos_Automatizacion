using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    internal class GestorReserva
    {
        public void Ejecutar() { }

        public GestorReserva()
        {

            Console.WriteLine("Gestor de Reservas inicializado.");
        }

        public bool ReservarSala(Reserva reserva, Evento evento, Sala sala)
        {
            if (sala.Reservar(evento))
            {
                Console.WriteLine($"Reserva exitosa: {reserva}");
                return true;
            }
            else
            {
                Console.WriteLine($"Reserva fallida: {reserva}");
                return false;
            }
        }

        public void CancelarReserva(Reserva reserva)
        {
            reserva.CancelarReserva();
        }

        public void ModificarReserva(Reserva reserva, DateTime nuevaFechaInicio, DateTime nuevaFechaFin, int nuevaCantidadPersonas)
        {
            reserva.ModificarReserva(nuevaFechaInicio, nuevaFechaFin, nuevaCantidadPersonas);
        }

        public void VerDetallesReserva(Reserva reserva)
        {
            reserva.VerDetalles();
        }
        private List<Reserva> reservas = new List<Reserva>();

        public void AgregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }

        public void ListarReservas()
        {
            foreach (var r in reservas)
            {
                r.VerDetalles();
            }
        }


    }
}
 

