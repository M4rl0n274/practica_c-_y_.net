using System;

namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        
        {

            byte numero = 255; // rango de 1 a 255
            sbyte numero2 = -128; // permite numeros negativos -128 a 127 
            int numero3 = 0; // permite engativos
            uint numero4 = 0; // permite solo numeros positivos
            long numero5 = 10; // permite numeros en rangos extensos
            ulong numero6 = 0; // permite negativos

            float numero7 = 15.5f; // numero flotante
            double numero8 = 15.4d; // 
            decimal numero9 = 189.31m; // 

            char caracter = 'A'; // caracter
            string caracter2 = "texto string"; // permite ams d eun caracter

            DateTime caracter3 = DateTime.Now; // fecha, fecha de este momento

            bool caracter4 = false; // true o false

            int numero10 = new int();
            Console.WriteLine(numero.ToString());

            int? numero11 = null; // para agregar un valor nulo se agrega "?"


            var nombre = "Marlon"; // es constante y se define su tipo con el contenido

            var persona = new { nombre = "Marlon", apellido = "Quintero" };   //base de todos los elementos de c#
            Console.WriteLine(persona.nombre);

        }

    }
}


