﻿using System;
using RPGPOO.src.Entities;

namespace RPGPOO
{


    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");


            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(arus.Attack());
        }
    }

}