﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

using System.Threading.Tasks;

namespace Theme13Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Phone ph1 = new Phone();
             Console.WriteLine($"{ph1.ToString()}\n");

             Phone ph2 = new Phone("SAsung","XXX21");
             Console.WriteLine($"{ph2.ToString()}\n");
             Phone ph3 = new Phone
             {
                 name = "Htc",
                 model = "Noname",
                 cost = 99999
             };
             Console.WriteLine($"{ph3.ToString()}\n");*/

            //Student man1 = new Student("Ivanov", 3);
            //WriteLine($"{man1.ShowInfo()}\n");

            //Student man2 = new Student("", -7);

            Student man3 = new Student();
            man3.Fam = 
            man3.Kurs = 3;
            WriteLine($"{man3.ShowInfo()}");



            Read();
        }
    }
}
