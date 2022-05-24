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
            Console.WriteLine("5)Valor Absoluto\n6)El Cuadrado de un num\n7)Raiz Cuadrada\n8)Sen\n9)Cos\n10)Parte entera de un decimal");
            do{
                op= Convert.ToInt32(Console.ReadLine());
                if((op <= 0 && op >= 11)){
                    Console.WriteLine("Elija una opción correcta");
                }
                if(op == 1){
                    Console.WriteLine("\tSuma");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} + {numDos} = {numUno + numDos}");
                }
                if(op == 2){
                    Console.WriteLine("\tResta");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} - {numDos} = {numUno - numDos}");
                }
                if(op == 3){
                    Console.WriteLine("\tMultiplicación");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} * {numDos} = {numUno * numDos}");
                }
                if(op == 4){
                    Console.WriteLine("\tDivisión");
                    Console.WriteLine("NUM UNO:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NUM DOS:");
                    numDos= Convert.ToInt32(Console.ReadLine());
                    if(numDos != 0){
                        Console.WriteLine($"{numUno} / {numDos} = {Convert.ToDecimal(numUno / numDos)}");
                    }else{
                        Console.WriteLine($"{numUno} + {numDos} = 0");
                    }
                }
                if(op == 5){
                    Console.WriteLine("\tValor Absoluto");
                    Console.WriteLine("NUM:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Valor Absoluto de {numUno} = {Convert.ToDecimal(Math.Abs(numUno))}");
                }
                if(op == 6){
                    Console.WriteLine("\tEl Cuadrado de un num");
                    Console.WriteLine("NUM:");
                    numUno= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{numUno} Al Cuadrado = {Math.Pow(numUno, 2)}");
                }
                if(op == 7){
                    double numR;
                    Console.WriteLine("\tRaiz Cuadrada");
                    Console.WriteLine("NUM:");
                    numR= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Raiz Cuadrada de {numR} = {Math.Sqrt(numR)}");
                }
                if(op == 8){
                    double numSin;
                    Console.WriteLine("\tSen");
                    Console.WriteLine("NUM:");
                    numSin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Sen de {numSin} = {Math.Sin(numSin)}");
                }
                if(op == 9){
                    double numCos;
                    Console.WriteLine("\tCos");
                    Console.WriteLine("NUM:");
                    numCos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Cos de {numCos} = {Math.Cos(numCos)}");
                }
                if(op == 10){
                    float numDec;
                    Console.WriteLine("\tParte entera de un decimal");
                    Console.WriteLine("NUM:");
                    numDec = float.Parse(Console.ReadLine());
                    Console.WriteLine($"Parte entera de {numDec} = {Math.Truncate(numDec)}");
                }

                Console.WriteLine("5)Valor Absoluto\n6)El Cuadrado de un num\n7)Raiz Cuadrada\n8)Sen\n9)Cos\n10)Parte entera de un decimal");
                Console.WriteLine("Presiona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\tCalculadora\n1)Suma\n2)Resta\n3)Multiplicación\n4)División.\n");

            }while(!(op <= 0 && op >= 11));
        }
    }
}