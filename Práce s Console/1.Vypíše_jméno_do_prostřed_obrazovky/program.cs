using System;
using System.Threading;
    using static System.Console;



    class Program
    {
        static void Main(string[] args)
        {
        int x, y;
        Write("Zadej jméno:");
        string jmeno = ReadLine();
        Clear();
        /*
        x = (120-jmeno.Length)/2;
        y = 30 / 2;
        
        SetCursorPosition(x,y);
        for (int i = 0; i < jmeno.Length; i++)
        {
            Write(jmeno[i]);
        }
        */
        y = 30 / 2;
        for (x=120-jmeno.Length;x>=0 ;x--)
        {
            SetCursorPosition(x, y);
            Write(jmeno);
            Thread.Sleep(10);
            if (x != 0) Clear();
            
        }
        ReadLine();
