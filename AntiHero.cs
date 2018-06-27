using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class AntiHero : SuperHuman
    {
        
        public int _lives { get; set; }
        public int _scores { get; set; }

        public AntiHero(string name, double strength, int lives, int scores) : base(name, strength)
        {
            _name = name;
            _strength = strength;
            _lives = lives;
            _scores = scores;
            

        }

        public AntiHero(string name, double strength, int v) : base(name, strength)
        {
            
        }
    }
}
