using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Lion : Animal
    {
        private const string SOUND = "Rour!";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Makes Sound: {SOUND}");
        }
    }
}
