using System;
using System.Collections.Generic;
using System.Text;

namespace LabBonus13
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; }

        public Warrior(string weaponType, string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"The character's name is: {Name}");
            Console.WriteLine($"Their Strength is: {Strength}");
            Console.WriteLine($"Their Intelligence is: {Intelligence}");
            Console.WriteLine($"Their Weapon Type is: {WeaponType}");
        }
    }
}
