using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=De9ZLfGIM18
namespace CodigoCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            CodigoCesar();
            Console.ReadKey();
        }

        static void CodigoCesar()
        {
            Console.WriteLine("realizar un programa que encripte un texto mediante el cifrado César. El usuario introducirá el texto, y el número de desplazamiento.");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Introduce el mensaje a cifrar");
            String texto = Console.ReadLine();
            texto = texto.ToUpper();
            Console.WriteLine("Introduce el número de desplazamiento");
            uint desplazamiento = Convert.ToUInt32(Console.ReadLine());
            char[] Caracteres = texto.ToCharArray();

            
            string resultado = "";
            for (int i = 0; i < Caracteres.Length; i++)
            {
                uint convertidos = Convert.ToUInt32(Caracteres[i]);
                Console.WriteLine("Posición " + (i + 1) + "=> " + Caracteres[i] + " Unicode = " + convertidos);
                if (convertidos > 'A' && convertidos < 'Z')
                {
                    Console.WriteLine("Estoy dentro");
                    //desplazamiento += desplazamiento;
                    convertidos = Convert.ToUInt32(Caracteres[i]);
                   
                   // if (convertidos > 'Z') { desplazamiento -= 26; }
                    //if (convertidos < 'A') { desplazamiento += 26; }
                }
            }
            resultado += desplazamiento;
        }
    }
}
