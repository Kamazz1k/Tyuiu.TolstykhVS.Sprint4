﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint4.Task6.V22.Lib;

namespace Tyuiu.TolstykhVS.Sprint4.Task6.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            var word = new string[] { "Снег", "Дождь", "Туман", "Град", "Ветер", "Туча", "Засуха" };



            Console.WriteLine(ds.Calculate(word));
            Console.ReadKey();
        }
    }
}
