﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Command Line Todo application");
            var ctrl = new Control();
            ctrl.Controller();
        }
    }
}