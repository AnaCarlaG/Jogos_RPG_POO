using System;
using Jogos_RPG_POO.src.Entities;

namespace Jogos_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");

            Console.WriteLine(hero.ToString());
        }
    }
}
