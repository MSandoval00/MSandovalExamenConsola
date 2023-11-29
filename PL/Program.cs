using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona nombrePersona = new Persona("Leonardo");//Método 1
            
            Persona persona = new Persona("Sandoval","Garcia");//Método 2
            string resultado = persona.Apellidos(persona.ApellidoPaterno,persona.ApellidoMaterno);
            Console.WriteLine(" Los apellidos son: "+resultado);
            Console.ReadLine();
            
        }
    }
}
