// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0, numUno=0, numDos=0;
            Console.WriteLine("\tCalculadora\n1)Suma\n2)Resta\n3)Multiplicación\n4)División.\n");
            do{
                op= Convert.ToInt32(Console.ReadLine());
                if((op <= 0 && op >= 5)){
                    Console.WriteLine("Elija una opción correcta");
                }
                if(op == 1){
                    Console.WriteLine("\tSuma");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} + {numDos}");
                    Console.WriteLine($"Resultado: {numUno + numDos}");
                }
                if(op == 2){
                    Console.WriteLine("\tResta");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} - {numDos}");
                    Console.WriteLine($"Resultado: {numUno - numDos}");
                }
                if(op == 3){
                    Console.WriteLine("\tMultiplicación");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} * {numDos}");
                    Console.WriteLine($"Resultado: {numUno * numDos}");
                }
                if(op == 4){
                    Console.WriteLine("\tDivisión");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} / {numDos}");
                    if(numDos != 0){
                        Console.WriteLine($"Resultado: {numUno / numDos}");
                    }else{
                        Console.WriteLine("Resultado: 0");
                    }
                }
                Console.WriteLine("Presiona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\tCalculadora\n1)Suma\n2)Resta\n3)Multiplicación\n4)División.\n");
            }while(!(op <= 0 && op >= 5));
        }
        public static int reverso(int num){
            int r=0, inv=0;
            if(num > 10){
               while(num != 0){
                    r = num % 10;
                    num = num / 10;
                    inv = (inv * 10) + r;
                }
                num = inv;
                return num;
            }
            return num;
        }
    }
}