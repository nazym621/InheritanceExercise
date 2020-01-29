using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird: Animal
    {
        public Bird()
        {
            Legs = 2;
            Eyes = true;
            Ears = true;
            Tongue = true;
        }

        public bool Wings { get; set; }
        public bool Feathers { get; set; }
        public bool Beak { get; set; }
        public string CanTalk { get; set; }

    }
}
