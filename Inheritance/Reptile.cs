using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile(string name, bool meateater, string noise, int legs, bool swim) : base(name, noise)
        {
            LaysEggs = true;
            ColdBlooded = true;
            EatsMeat = meateater;
            NumLegs = legs;
            Swimming = swim;
        }
        public bool ColdBlooded { get; set; }
        public bool Swimming { get; set; }
        public string Sunbathe()
        {
            return $"{Name} enjoys hanging out in the sun";
        }
        public string Slither()
        {
            if (NumLegs == 0) return $"{Name} slithers around!";
            else return $"{Name} can't do that";
        }
    }
}
