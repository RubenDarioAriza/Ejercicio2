using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            char sexo;
            double pulsaciones;
            Console.Write("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Digite su sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());
            if (sexo.Equals("F"))
            {
                pulsaciones = (220 - edad) / 10;
            }
            else
            {
                pulsaciones = (210 - edad) / 10;
            }
            Console.Write("Sus pulsaciones son: " + pulsaciones);
        }
    }
}
        
    

