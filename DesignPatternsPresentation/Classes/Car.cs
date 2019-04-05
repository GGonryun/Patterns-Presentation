using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    public class Car
    {
        public void Drive(int speed)
        {
            Console.WriteLine($"Driving at a steady {speed} mph!");
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }

    }
}
