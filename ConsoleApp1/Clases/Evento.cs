using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Clases
{
    public class Evento
    {
        public void Ejecutar()
        {
            Console.WriteLine("Ejecutando método de la clase Evento.");
        }

        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime Fechafin { get; set; }

        public string ContactoOrganizador { get; set; }
        public string NotasPrivadas { get; set; }

        public string TipoEvento { get; set; }

        public Evento(string nombre, DateTime inicio, DateTime fin, string contacto, string nota)
        {
            Nombre = nombre;
            FechaInicio = inicio;
            Fechafin = fin;
            ContactoOrganizador = contacto;
            NotasPrivadas = nota;

            TipoEvento = "clase"; // ✅ Valor por defecto para evitar el error
        }

        public void CambiarContacto(string nuevoContacto)
        {
            if (!string.IsNullOrEmpty(nuevoContacto))
            {
                ContactoOrganizador = nuevoContacto;
            }
        }

        public void CambiarNotas(string nuevasNotas)
        {
            if (!string.IsNullOrEmpty(nuevasNotas))
            {
                NotasPrivadas = nuevasNotas;
            }
        }

        public string verNotas()
        {
            return "Notas protegidas: " + NotasPrivadas;
        }
    }
}
