using System;
using ConsoleApp1.Clases;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Sala sala = new SalaComun("Sala de Reuniones", 30, "Edificio A");


            Evento evento = new Evento(
                nombre: "Taller de Liderazgo",
                inicio: DateTime.Now,
                fin: DateTime.Now.AddHours(2),
                contacto: "jefe@universidad.edu",
                nota: "Llevar rotafolio"
            );


            Console.WriteLine("\n--- DETALLES DE LA SALA ---");
            sala.VerDetalles();

            Console.WriteLine("\n--- DETALLES DEL EVENTO ---");
            Console.WriteLine($"Evento: {evento.Nombre}");
            Console.WriteLine($"Fecha: {evento.FechaInicio} a {evento.Fechafin}");
            Console.WriteLine($"Contacto: {evento.ContactoOrganizador}");


            Console.WriteLine("\n--- PROCESANDO RESERVA ---");
            bool exito = sala.Reservar(evento);

            if (exito)
            {
                Console.WriteLine(" Reserva confirmada.");
            }
            else
            {
                Console.WriteLine(" Reserva rechazada.");
            }


            Console.WriteLine("\n" + evento.verNotas());

            Console.WriteLine("\n--- FIN DEL PROGRAMA ---");
        }
    }
}
