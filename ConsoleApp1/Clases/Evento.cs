using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Evento
    {
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime Fechafin { get; set; }


        public string ContactoOrganizador { get; set; }
        public string NotasPrivadas { get; set; }



        public Evento(string nombre, DateTime inicio, DateTime fin, string contacto, string nota)
        {
            Nombre = nombre;
            FechaInicio = inicio;
            Fechafin = fin;
            ContactoOrganizador = contacto;
            NotasPrivadas = nota;

        }

        public void CambiarContacto(string nuevoContacto)
        {
            if (nuevoContacto != null && nuevoContacto != "")
            {
                ContactoOrganizador = nuevoContacto;
            }
        }

        public string verNotas()
        {
            return "Notas protegidas :" + NotasPrivadas;
        }
    }
}