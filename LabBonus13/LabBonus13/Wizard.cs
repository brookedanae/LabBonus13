using System;
using System.Collections.Generic;
using System.Text;

namespace LabBonus13
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; }

        public Wizard(int spellNumber, int magicalEnergy, string name, int strength, int intelligence) : base(magicalEnergy, name, strength, intelligence)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"The character's name is: {Name}");
            Console.WriteLine($"Their Strength is: {Strength}");
            Console.WriteLine($"Their Intelligence is: {Intelligence}");
            Console.WriteLine($"Their Magical Energy is: {MagicalEnergy}");
            Console.WriteLine($"Their Spell Number is: {SpellNumber}");

        }
    }
}
