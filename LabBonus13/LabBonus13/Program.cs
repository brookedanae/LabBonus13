using System;
using System.Collections.Generic;

namespace LabBonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----> Your Main Characters are:");
            Console.WriteLine("\n");

            // Original 3 Characters
            Warrior charWarrior = new Warrior("One-Handed Sword", "Cartel", 15, 5);
            charWarrior.Play();
            Console.WriteLine("\n");

            MagicUsingCharacter charMUC = new MagicUsingCharacter(17, "Tandistra", 3, 10);
            charMUC.Play();
            Console.WriteLine("\n");

            Wizard charWizard = new Wizard(23, 20, "Dumbledore", 5, 32);
            charWizard.Play();
            Console.WriteLine("\n");
            Console.WriteLine("----> Your 5 new companions are:");
            Console.WriteLine("\n");

            // Five new characters for Pt. 3
            Warrior charWarrior1 = new Warrior("Duel-wielding One-Handed Swords", "Parzival", 22, 9);
            charWarrior1.Play();
            Console.WriteLine("\n");

            Warrior charWarrior2 = new Warrior("Axe", "Jane", 13, 7);
            charWarrior2.Play();
            Console.WriteLine("\n");

            Wizard charWizard1 = new Wizard(14, 18, "Hermione", 4, 20);
            charWizard1.Play();
            Console.WriteLine("\n");

            Wizard charWizard2 = new Wizard(10, 16, "Ron", 7, 16);
            charWizard2.Play();
            Console.WriteLine("\n");

            Wizard charWizard3 = new Wizard(17, 21, "Harry", 9, 20);
            charWizard3.Play();

            // Adding an array for the 5 new characters
            GameCharacter[] gameCharacters = new GameCharacter[5];
            gameCharacters[0] = charWarrior1;
            gameCharacters[1] = charWarrior2;
            gameCharacters[2] = charWizard1;
            gameCharacters[3] = charWizard2;
            gameCharacters[4] = charWizard3;

            // Adding the For loop to invoke the Play Method for all the Objects in the Array
            for (int i = 0; i < gameCharacters.Length; i++)
            {
                Console.WriteLine("");
            }

        }


    }
}
