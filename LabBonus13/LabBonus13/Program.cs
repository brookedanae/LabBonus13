using System;
using System.Collections.Generic;

namespace LabBonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a character name: ");
            //var userInput = Console.ReadLine();

            var gameCharacters = new List<GameCharacter>();

            Warrior charName1 = new Warrior("One-Handed Sword", "Cartel", 15, 5);
            charName1.Play();
            Console.WriteLine("\n");

            MagicUsingCharacter charName2 = new MagicUsingCharacter(17, "Tandistra", 3, 10);
            charName2.Play();
            Console.WriteLine("\n");


            Wizard charName3 = new Wizard(23, 15, "Dumbledore", 5, 32);
            charName3.Play();
            Console.WriteLine("\n");

        }
    }
}
