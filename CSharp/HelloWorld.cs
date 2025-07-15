using System;
using System.Runtime.CompilerServices;

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

            int myInt = 11;
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

            // Estructuras

            var myArray = new string[] { "Marlon", "Quintero" };
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);

            var myDictionary = new Dictionary<string, int>
            {
                {"Marlon", 20},
                {"Marlon 2", 21},
                {"Marlon 3", 22}
            };
            Console.WriteLine(myDictionary["Marlon"]);

            var mySet = new HashSet<string>{
                 "Marlon", "Quintero"};
            Console.WriteLine(mySet);

            var myTuple = ("Marlon", "Quintero");
            Console.WriteLine(myTuple);

            // Bucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }

            //Flujos

            myInt = 11;

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");

            }
            else
            {
                Console.WriteLine("El valor no es 11 ni 12");

            }

            // Funciones
            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            //clases
            var myClass = new Myclass("Marlon");
            myClass.myName = "Marlon2";
            Console.WriteLine(myClass.myName);

        }

        static void MyFunction()
        {
            Console.WriteLine("Mi funcion");
        }
        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class Myclass
        {
            public string myName { get; set; }

            public Myclass(string myCurrentName)
            {
                myName = myCurrentName;
            }
        }




    }

}
