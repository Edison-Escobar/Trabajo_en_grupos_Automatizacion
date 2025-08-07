using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Auditorio : Sala
    {
        public bool TieneSonido { get; set; }

        public Auditorio(string nombre, int capacidad, string ubicacion, bool sonido)
            : base(nombre, capacidad, ubicacion)
        {
            TieneSonido = sonido;
        }

        public override bool Reservar(Evento evento)
        {
            if (Capacidad >= 50)
            {
                Console.WriteLine($"Auditorio '{Nombre}' reservado para: {evento.Nombre}");
                return true;
            }
            else
            {
                Console.WriteLine($"Auditorio '{Nombre}' rechazado (capacidad insuficiente).");
                return false;
            }

        }
        public override string ToString()
        {
            return $"Auditorio: {Nombre}, Capacidad: {Capacidad}, Ubicacion: {Ubicacion}, Tiene Sonido: {TieneSonido}";
        }
        public override void VerDetalles()
        {
            base.VerDetalles();
            Console.WriteLine($"Tiene Sonido: {TieneSonido}");
        }
    }
}
