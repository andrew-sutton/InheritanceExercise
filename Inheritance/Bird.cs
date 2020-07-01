using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public Bird(string name, bool meateater,string noise,bool flying) : base(name, noise)
        {
            NumLegs = 2;
            NumWings = 2;
            LaysEggs = true;
            EatsMeat = meateater;
            CanFly = flying;
        }
        public bool CanFly { get; set; }
        public string BeakType { get; set; }
        public int NumWings { get; set; }

        public string Sing()
        {
            return Noise;
        }
        public string Fly()
        {
            if (CanFly)
            {
                return $"{Name} takes off into the air!";
            }
            else return $"{Name} can't do that";
        }
    }
}
