using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Persona
    {
        public string Nombre= "Leonardo";
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        protected string[] Lista { get; set; }

        
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        public Persona(string apellidoPaterno,string apellidoMaterno)
        {
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
        }
        protected static string NombreCompleto(string Nombre)
        {
            return Nombre;
        }
        public  string Apellidos(string ApellidoPaterno,string ApellidoMaterno)
        {
            
            string[] Lista = { "Hola", "Todos", "Como", "Estan" };
            for (int i = 0; i < Lista.Length; i++)
            {
                string elementos=Lista[i];
                Console.Write($"Mensaje {i} " + elementos);
            }
            string union = ApellidoPaterno + " " + ApellidoMaterno;
            return union;
        }


    }
}
