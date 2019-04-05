using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    public class MoveLikeADog : IMove
    {
        void IMove.Move()
        {
            Console.WriteLine("Walking forward one paw after the other, like a dog would I guess.");
        }
    }
}
