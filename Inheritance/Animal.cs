using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public Animal(string name,string noise)
        {
            Name = name;
            Noise = noise;
        }
        public string Name { get; set; }
        public int NumLegs { get; set; }
        public bool EatsMeat { get; set; }
        public string Noise { get; set; }
        public bool LaysEggs { get; set; }
        public string Consume(string food)
        {
            if (food == "meat")
            {
                if (EatsMeat) return $"{Name} eats {food}";
                else return $"{Name} cannot eat that";
            }
            else return $"{Name} eats {food}";
        }
        public string Reproduce()
        {
            if (LaysEggs) return $"{Name} lays an egg!";
            else return $"{Name} gives birth!";
        }
    }
}
