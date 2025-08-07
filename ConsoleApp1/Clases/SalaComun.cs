using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class SalaComun : Sala
    {
        public void Ejecutar()

        {
            Console.WriteLine("Ejecutando método de la clase SalaComun.");

        }

        public SalaComun(string nombre, int capacidad, string ubicacion)
            : base(nombre, capacidad, ubicacion)
        {
        }

        public override bool Reservar(Evento evento)
        {
            Console.WriteLine($"Sala común '{Nombre}' reservada para: {evento.Nombre}");
            return true;
        }
        public override string ToString()
        {
            return $"Sala Común: {Nombre}, Capacidad: {Capacidad}, Ubicacion: {Ubicacion}";
        }
        public override void VerDetalles()
        {
            base.VerDetalles();
            Console.WriteLine("Esta es una sala común, ideal para reuniones informales.");
        }
         
    }
}