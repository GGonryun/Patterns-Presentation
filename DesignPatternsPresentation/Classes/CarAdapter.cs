using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    class CarAdapter : ISpeak, IMove
    {
        Car car;
        int speed;

        public CarAdapter(Car car, int speed)
        {
            this.car = car;
            this.speed = speed;
        }

        void IMove.Move()
        {
            car.Drive(speed);
        }

        void ISpeak.Speak()
        {
            car.Honk();
        }
    }
}
