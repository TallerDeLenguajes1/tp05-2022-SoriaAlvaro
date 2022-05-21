// See https://aka.ms/new-console-template for more information

using System;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverso(123));    
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