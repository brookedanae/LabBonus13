using System;
using System.Collections.Generic;
using System.Text;

namespace LabBonus13
{
    class MagicUsingCharacter : GameCharacter
    {

        public int MagicalEnergy { get; }

        public MagicUsingCharacter(int magicalEnergy, string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"The character's name is: {Name}");
            Console.WriteLine($"Their Strength is: {Strength}");
            Console.WriteLine($"Their Intelligence is: {Intelligence}");
            Console.WriteLine($"Their Magical Energy is: {MagicalEnergy}");

        }


    }
}

