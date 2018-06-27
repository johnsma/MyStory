using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain : SuperHuman
    {
        public int _health { get; set; }
        public int _weapons { get; set; }
        public int _ammunition { get; set; }

        public SuperVillain(string name, double strength, int hp, int weapons, int ammo) : base(name, strength)
        {
            _name = name;
            _strength = strength;
            _health = hp;
            _weapons = weapons;
            _ammunition = ammo;

        }

        public void _HP(int _hits)
        {
            if (_hits == 40)
            {
                Console.WriteLine("you are doing good");

            }
            else if (_hits <= 10)
            {
                Console.WriteLine("you are getting cold");
            }
            else
            {
                Console.WriteLine("keep it going");
            }
        }
    }
}