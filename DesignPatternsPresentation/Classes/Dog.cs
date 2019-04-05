using System;

namespace DesignPatternsPresentation.Classes
{
    public class Dog : Animal2
    {
        public override void Move()
        {
            Console.WriteLine("Walking forward one paw after the other, like a dog would I guess.");
        }

        public void Speak()
        {
            Console.WriteLine("Bark!");
        }
    }
}
