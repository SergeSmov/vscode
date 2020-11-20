using System;
using System.Collections.Generic;
using System.Text;

namespace Bowl
{
    public class Player
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Player(string number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}
