using System;
using RPGPOO.src.Entities;

namespace RPGPOO
{


    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");


            Console.WriteLine(wizard.Attack());
            Console.WriteLine(arus.Attack());
        }
    }

}