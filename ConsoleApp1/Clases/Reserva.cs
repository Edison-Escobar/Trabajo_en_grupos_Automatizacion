using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Clases
{
    internal class Reserva
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando método de la clase Reserva.");
        }

        public int Id { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadPersonas { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string EmailCliente { get; set; }
        public string Comentarios { get; set; }

        public Reserva(int id, DateTime fechaReserva, DateTime fechaInicio, DateTime fechaFin, int cantidadPersonas,
            string nombreCliente, string telefonoCliente, string emailCliente, string comentarios)
        {
            Id = id;
            FechaReserva = fechaReserva;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            CantidadPersonas = cantidadPersonas;
            NombreCliente = nombreCliente;
            TelefonoCliente = telefonoCliente;
            EmailCliente = emailCliente;
            Comentarios = comentarios;
        }

        public override string ToString()
        {
            return $"Reserva ID: {Id}, Cliente: {NombreCliente}, Fecha Reserva: {FechaReserva}, Fecha Inicio: {FechaInicio}, Fecha Fin: {FechaFin}, Cantidad Personas: {CantidadPersonas}, Teléfono: {TelefonoCliente}, Email: {EmailCliente}, Comentarios: {Comentarios}";
        }


        public virtual bool Reservar(Evento evento)
        {
            Console.WriteLine($"Reserva directa para evento: {evento.Nombre}");
            return true; 
        }

        public virtual bool Reservar(Evento evento, Sala sala)
        {
            return sala.Reservar(evento); 
        }

        public virtual void CancelarReserva()
        {
            Console.WriteLine($"Reserva ID: {Id} cancelada.");
        }

        public virtual void ModificarReserva(DateTime nuevaFechaInicio, DateTime nuevaFechaFin, int nuevaCantidadPersonas)
        {
            FechaInicio = nuevaFechaInicio;
            FechaFin = nuevaFechaFin;
            CantidadPersonas = nuevaCantidadPersonas;
            Console.WriteLine($"Reserva ID: {Id} modificada. Nueva Fecha Inicio: {FechaInicio}, Nueva Fecha Fin: {FechaFin}, Nueva Cantidad Personas: {CantidadPersonas}");
        }

        public virtual void VerDetalles()
        {
            Console.WriteLine($"Detalles de la Reserva ID: {Id}");
            Console.WriteLine($"Cliente: {NombreCliente}");
            Console.WriteLine($"Fecha Reserva: {FechaReserva}");
            Console.WriteLine($"Fecha Inicio: {FechaInicio}");
            Console.WriteLine($"Fecha Fin: {FechaFin}");
            Console.WriteLine($"Cantidad Personas: {CantidadPersonas}");
            Console.WriteLine($"Teléfono: {TelefonoCliente}");
            Console.WriteLine($"Email: {EmailCliente}");
            Console.WriteLine($"Comentarios: {Comentarios}");
        }

        public virtual void ConfirmarReserva()
        {
            Console.WriteLine($"Reserva ID: {Id} confirmada.");
        }
    }
}
