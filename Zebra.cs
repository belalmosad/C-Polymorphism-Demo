using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zebra : Animal
    {
        private const string SOUND = "Neigh!";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Makes Sound: {SOUND}");
        }
    }
}
