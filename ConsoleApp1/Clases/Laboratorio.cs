using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Laboratorio : Sala
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando método de la clase Laboratorio.");
        }
        public int CantidadComputadoras { get; set; }

        public Laboratorio(string nombre, int capacidad, string ubicacion, int computadoras)
            : base(nombre, capacidad, ubicacion)
        {
            CantidadComputadoras = computadoras;
        }

        public override bool Reservar(Evento evento)
        {
            if(CantidadComputadoras > 0)
            {
                Console.WriteLine($"Laboratorio '{Nombre}' reservado para: {evento.Nombre}");
                return true;
            }
            else
            {
                Console.WriteLine($"Laboratorio '{Nombre}' rechazado (no hay computadoras).");
                return false;
            }
        }

    }

     
}
