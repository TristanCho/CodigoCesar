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
                Console.WriteLine("Introduce el número de desplazamiento");
                desplazamiento = Convert.ToUInt32(Console.ReadLine());
                Caracteres = texto.ToCharArray();

                longitud = Caracteres.Length;
                Console.WriteLine("Longitud= " + longitud);
                CifrarMensaje(desplazamiento, texto, longitud);
                Console.WriteLine("PARA DECIFRAR UN MENSAJE PULSE 0 ---- PARA CIFRAR OTRO MENSAJE PULSE 1");
                ORDEN = Convert.ToInt32(Console.ReadLine());
            } while (ORDEN == 1);

            //DECIFRAR
            Console.WriteLine("Introduce el mensaje a Decifrar");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            Console.WriteLine("Introduce el número de desplazamiento");
            desplazamiento = Convert.ToUInt32(Console.ReadLine());
            Caracteres = texto.ToCharArray();

            longitud = Caracteres.Length;
            Console.WriteLine("Longitud= " + longitud);
            DeCifrarMensaje(desplazamiento, texto, longitud);
           

            Console.ReadKey();
        }

        public static void CifrarMensaje(uint clave, string mensaje, int longitud)
        {

            char[] mochila = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                uint valorX = clave + mensaje[i];
                if (valorX > 'A' && valorX < 'Z') {
                    
                if (valorX>'Z')
                {
                    valorX -= 26;
                }
                if (valorX<'A')
                {
                    valorX += 26;
                }
                    //else
                      //  Console.WriteLine("!Letra=" + valorX);
                }
                char ValorConvertido = Convert.ToChar(valorX);
                mochila[i]= ValorConvertido;
                //pendiente de revisar los espacios... permitir ingresar sólo las letras if alpha que haga bien los espacios, verificar que luego se pueda desencriptar también
                //No tardes mucho que hay que hacer las pacs ..
            }
            Console.WriteLine(mochila);
        }

        public static void DeCifrarMensaje(uint clave, string mensaje, int longitud)
        {

            char[] mochila = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                
                uint valorX = mensaje[i] -clave;
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
                //else
                  //  Console.WriteLine("!Letra="+valorX);
                
                char ValorConvertido = Convert.ToChar(valorX);
                mochila[i] = ValorConvertido;
                //pendiente de revisar los espacios... permitir ingresar sólo las letras if alpha que haga bien los espacios, verificar que luego se pueda desencriptar también
                //No tardes mucho que hay que hacer las pacs ..
            }
            Console.WriteLine(mochila);
        }
    }
}
