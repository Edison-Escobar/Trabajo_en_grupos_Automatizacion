using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public abstract class Sala
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando método de la clase Sala.");
        }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { set; get; }

        public Sala(string nombre, int capacidad, string ubicacion)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            Ubicacion = ubicacion;
        }

        public abstract bool Reservar(Evento evento);
        public override string ToString()
        {
            return $"Sala: {Nombre}, Capacidad: {Capacidad}, Ubicacion: {Ubicacion}";
        }
        public virtual void CancelarReserva()
        {
            Console.WriteLine($"Reserva de la sala '{Nombre}' cancelada.");
        }
        public virtual void ModificarReserva(DateTime nuevaFechaInicio, DateTime nuevaFechaFin, int nuevaCantidadPersonas)
        {
            Console.WriteLine($"Reserva de la sala '{Nombre}' modificada. Nueva Fecha Inicio: {nuevaFechaInicio}, Nueva Fecha Fin: {nuevaFechaFin}, Nueva Cantidad Personas: {nuevaCantidadPersonas}");
        }
        public virtual void VerDetalles()
        {
            Console.WriteLine($"Detalles de la sala '{Nombre}':");
            Console.WriteLine($"Capacidad: {Capacidad}");
            Console.WriteLine($"Ubicacion: {Ubicacion}");

        }
    }
}
