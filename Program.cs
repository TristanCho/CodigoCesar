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
            Console.WriteLine("realizar un programa que encripte un texto mediante el cifrado César. El usuario introducirá el texto, y el número de desplazamiento.");
            Console.WriteLine("\n\n\n\n");
            String texto;
          
            Console.WriteLine("Introduce el mensaje a cifrar");
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            Console.WriteLine("Introduce el número de desplazamiento");
            uint desplazamiento = Convert.ToUInt32(Console.ReadLine());
            char[] Caracteres = texto.ToCharArray();
            /*
            bool comprobacion = Caracteres[].isLetterOrDigit();
            if (comprobacion)
            {

            }*/
            int longitud = Caracteres.Length;
            Console.WriteLine("Longitud= " + longitud);
            CifrarMensaje(desplazamiento, texto, longitud);

            Console.ReadKey();
        }

        public static void CifrarMensaje(uint clave, string mensaje, int longitud)
        {

            char[] mochila = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                
                uint valorX = clave + mensaje[i];
                if (valorX>'Z')
                {
                    valorX -= 26;
                }
                if (valorX<'A')
                {
                    valorX += 26;
                }
                char ValorConvertido = Convert.ToChar(valorX);
                mochila[i]= ValorConvertido;
                //pendiente de revisar los espacios... permitir ingresar sólo las letras if alpha que haga bien los espacios, verificar que luego se pueda desencriptar también
                //No tardes mucho que hay que hacer las pacs ..
            }
            Console.WriteLine(mochila);
        }
    }
}
