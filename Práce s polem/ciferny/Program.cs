using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int jedno_ciferne = 0, dvou_ciferne = 0, troj_ciferne = 0;
            Write("Zadej počet čísel, které budeš zadávat :");
            int velikost_pole = int.Parse(ReadLine());


            int[] arr = new int[velikost_pole];


            for(int i = 0; i < velikost_pole; i++)
            {
                arr[i] = r.Next(0, 999);
                Write(arr[i] + " | ");
                if (arr[i] <= 9) { jedno_ciferne++; }
                if (arr[i] >= 10 && arr[i] <= 99) { dvou_ciferne++; }
                if (arr[i] >= 100 && arr[i] <= 999) { troj_ciferne++; }
            }
            Write("\n");
            Write($"Jednociferné : {jedno_ciferne} | Dvouciferné : {dvou_ciferne} | Víceciferné {troj_ciferne}");
            ReadLine();



        }
    }
}
 
