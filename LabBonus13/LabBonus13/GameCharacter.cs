using System;
using System.Collections.Generic;
using System.Text;

namespace LabBonus13
{
    class GameCharacter
    {
        public string Name { get; }

        public int Strength { get; }

        public int Intelligence { get; }


        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public virtual void Play()
        {
            Console.WriteLine($"Your character's name is: {Name}");
            Console.WriteLine($"Their Strength is: {Strength}");
            Console.WriteLine($"Their Intelligence is: {Intelligence}");
        }
    }
}
