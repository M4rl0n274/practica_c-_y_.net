using System;

namespace CSharpHelloWorld
{

    class HelloWorld
    {

        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hello, C#");

            /*
            Esto 
            es 
            un
            comentario
            */

            string myString = "Esto es una cadena de texto";
            myString = "Aqui cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 10;
            myInt = myInt + 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5f;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            Console.WriteLine(myInt + myFloat + myDouble);

            bool myBool = true;
            Console.WriteLine(myBool);


            dynamic myDinamic = 6;
            myDinamic = "Mi dato dinamico";
            Console.WriteLine(myDinamic);

            var myVar = "Mi variable de tipo inferido";
            // myVar = 6; Error 
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool {myBool} ");


            const string MyConst = "mi constante";
            Console.WriteLine(MyConst);

            //



        }
    }

}
