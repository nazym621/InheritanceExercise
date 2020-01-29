using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile: Animal
    {
        public Reptile()
        {
            Ears = true;
            Tongue = true;
            Eyes = true;
            Legs = 0 - 4;
        }


        public bool Scales { get; set; }
        public bool ColdBlooded { get; set; }
        public string SnakeTypes { get; set; }
        public bool ProduceEggs { get; set; }
    }
}
