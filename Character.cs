using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTBIM
{
    public class Character
    {
        private int _health;
        public int Maxhealth { get; set; } = 100;
        public string Name { get; set; }
        public int Health //properties
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0; // = get{ return _health};
                else if (value > Maxhealth)
                {
                    _health = Maxhealth;
                    Console.WriteLine("Gia tri cua value:" + value);

                }
                else _health = value;

            }
        }
        public Character(String name, int health) //feild( field phai cung ten voi class
        {
            Name= name;
            Health= health;
        }
        

    }
}
