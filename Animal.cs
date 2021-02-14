using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        
        public string Type { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The animal type is: {Type}");
            Console.WriteLine($"The animal age is: {Age}");
            Console.WriteLine($"The animal gender is: {Gender}");
            Console.WriteLine($"The animal height is: {Height}");
            Console.WriteLine($"The animal weight is: {Weight}");
        }
    }
}
