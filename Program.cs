// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCalculadora");
            Console.WriteLine("Ingrese un Num: ");
            int op=0;
            do{
                Console.WriteLine("Num:");
                double num = Convert.ToDouble(Console.ReadLine());
                opciones();
                op= Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if((op <= 0 && op >= 13)){Console.WriteLine("Elija una opción correcta");}
                if(op > 0 && op < 5){Console.WriteLine("Num 2: ");}
                if(op == 1){suma(num);}
                if(op == 2){resta(num);}
                if(op == 3){mult(num);}
                if(op == 4){div(num);}
                if(op == 5){max(num);}
                if(op == 6){men(num);}
                if(op == 7){abs(num);}
                if(op == 8){cuadrado(num);}
                if(op == 9){raiz(num);}
                if(op == 10){sen(num);}
                if(op == 11){cos(num);}
                if(op == 12){partEnt(num);}
                Console.WriteLine("Presiona ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingrese un Num: ");
            }while(!(op <= 0 && op >= 13));
        }

        static void opciones(){
            Console.WriteLine("\tElija una opción\n1) +\n2) -\n3) X\n4) /\n5)Mayor entre 2 num\n6)Menor entre 2 num\n7)Abs\n8)Cuadrado de un num\n9)Raiz Cuadrada\n10)Sen\n11)Cos\n12)Parte entera de un decimal");
        }
        static void suma(double num){
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"{((int)num)} + {num2}= {((int)num) + num2}");
        }
        static void resta(double num){
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"{((int)num)} - {num2}= {((int)num) - num2}");
        }
        static void mult(double num){
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"{((int)num)} * {num2}= {((int)num) * num2}");
        }
        static void div(double num){
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            if(num2 != 0){Console.WriteLine($"{num} / {num2} = {(num / num2)}");}
            else{Console.WriteLine($"{num} / {num2} = 0");}
        }

        static void abs(double num){
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"ValAbs de {num}= {(Math.Abs(num))}");
        }
        static void cuadrado(double num){
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"Cuadrado de {num} = {Math.Pow(num,2)}");
        }
        static void raiz(double num){
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"Raiz de {num} = {(Math.Sqrt(num))}");
        }
        static void sen(double num){
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"Sen de {num} = {(Math.Sin(num))}");
        }
        static void cos(double num){
            Console.Clear();
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"Cos de {num} = {(Math.Cos(num))}");
        }
        static void partEnt(double num){
            Console.Clear();
            float numF =(float)num;
            Console.WriteLine("\tRESULTADO");
            Console.WriteLine($"Parte entera de {num} = {Math.Truncate(numF)}");
        }
        static void max(double num){
            Console.Clear();
            Console.WriteLine($"Num uno: {num}");
            Console.WriteLine("Num Dos: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if(num > num2){Console.WriteLine($"Max = {num}");}
            Console.WriteLine($"Max = {num2}");
        }
        static void men(double num){
            Console.Clear();
            Console.WriteLine($"Num uno: {num}");
            Console.WriteLine("Num Dos: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if(num < num2){Console.WriteLine($"Men = {num}");}
            Console.WriteLine($"Max = {num2}");
        }
        
    }
}