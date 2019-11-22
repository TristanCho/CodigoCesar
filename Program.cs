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
            Console.WriteLine("realizar un programa que encripte un texto mediante el cifrado César. \n" +
                "El usuario introducirá el texto, y el número de desplazamiento.");
            Console.WriteLine("\n\n\n\n");
            String texto;
            int ORDEN = 0;
            uint desplazamiento;
            char[] Caracteres;
            int longitud;


            do
            {
                //CIFRAR
                Console.WriteLine("Introduce el mensaje a cifrar");
                texto = Console.ReadLine();
                texto = texto.ToUpper();
                string Input;

                do
                {
                    Console.WriteLine("Introduce el número de desplazamiento");
                    Input = Console.ReadLine();
                    while (Input == null)
                    {
                        Console.WriteLine("No se admiten valores nulos");
                        Console.WriteLine("Introduce el número de desplazamiento");
                        Input = Console.ReadLine();
                        Console.Clear();
                    }
                    desplazamiento = Convert.ToUInt32(Input);
                    while (desplazamiento>9)
                    {
                        Console.WriteLine("Inserta un número menor que 10");
                        Input = Console.ReadLine();
                        desplazamiento = Convert.ToUInt32(Input);
                        Console.Clear();
                    }
                }

                while (Input == null);

                
                Caracteres = texto.ToCharArray();

                longitud = Caracteres.Length;
                //Console.WriteLine("Longitud= " + longitud);
                CifrarMensaje(desplazamiento, texto, longitud);
                Console.WriteLine("PARA DECIFRAR UN MENSAJE PULSE 0 ---- PARA CIFRAR OTRO MENSAJE PULSE 1");
                ORDEN = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (ORDEN == 1);

            //DECIFRAR
            Console.WriteLine("Introduce el mensaje a Decifrar");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            Console.WriteLine("Introduce el número de desplazamiento");
            desplazamiento = Convert.ToUInt32(Console.ReadLine());
            Caracteres = texto.ToCharArray();

            longitud = Caracteres.Length;
           // Console.WriteLine("Longitud= " + longitud);
            DeCifrarMensaje(desplazamiento, texto, longitud);
            Console.ReadKey();
        }

        public static void CifrarMensaje(uint clave, string mensaje, int longitud)
        {

            char[] mochila = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                uint valorX = clave + mensaje[i];
                if (valorX > 'A' && valorX < 'Z')
                {

                    if (valorX > 'Z')
                    {
                        valorX -= 26;
                    }
                    if (valorX < 'A')
                    {
                        valorX += 26;
                    }

                }
                char ValorConvertido = Convert.ToChar(valorX);
                mochila[i] = ValorConvertido;


            }
            Console.Write("RESULTADO: ");
            Console.WriteLine(mochila);
        }

        public static void DeCifrarMensaje(uint clave, string mensaje, int longitud)
        {

            char[] mochila = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {

                uint valorX = mensaje[i] - clave;
                if (valorX > 'A' && valorX < 'Z')
                {
                    if (valorX > 'Z')
                    {
                        valorX -= 26;
                    }
                    if (valorX < 'A')
                    {
                        valorX += 26;
                    }
                }

                char ValorConvertido = Convert.ToChar(valorX);
                mochila[i] = ValorConvertido;

            }
            Console.Write("RESULTADO: ");
            Console.WriteLine(mochila);
        }
    }
}
