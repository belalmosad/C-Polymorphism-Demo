using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Animal
    {
        private const string SOUND = "Whoop!";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Makes Sound: {SOUND}");
        }
    }
}
