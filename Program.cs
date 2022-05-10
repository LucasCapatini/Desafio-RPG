using System;
using Desafio_RPG.src.Entities;

namespace Desafio_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jenica = new Wizard("Jenica", 23, "White Wizard");
            Ninja wedge = new Ninja("Wedge", 21, "Ninja");
            BlackWizard topapa = new BlackWizard("topapa", 22, "Black Wizard");

            Console.WriteLine(arus.Attack(5));
            Console.WriteLine(jenica.Attack(8));
            Console.WriteLine(wedge.Attack(9));
            Console.WriteLine(topapa.Attack(2));
        }
    }
}