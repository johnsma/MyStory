using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman
    {
        public double  _power { get; set; }
        public int _points { get; set; }

        public SuperHero(string name, double strength, double power, int points) : base(name, strength)
        {
            _name = name;
            _strength = strength;
            _power = power;
            _points = points;


        }

    }
}
    

