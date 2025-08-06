using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class SalaComun : Sala
    {
        public SalaComun(string nombre, int capacidad, string ubicacion)
            : base(nombre, capacidad, ubicacion)
        {
        }

        public override bool Reservar(Evento evento)
        {
            Console.WriteLine($"Sala común '{Nombre}' reservada para: {evento.Nombre}");
            return true;
        }
    }
}