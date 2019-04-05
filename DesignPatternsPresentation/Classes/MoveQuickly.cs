using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    public class FastMovement : IMove
    {
        IMove movement;
        int speed;

        public FastMovement(IMove movement, int speed)
        {
            this.movement = movement;
            this.speed = speed;
        }

        void IMove.Move()
        {
            Console.WriteLine("We're about to go really fast!");
            for(int i = 0; i < speed; i++)
            {
                movement.Move();
            }
            Console.WriteLine("Lets take a breather... I'm tired now...");
        }
    }
}
