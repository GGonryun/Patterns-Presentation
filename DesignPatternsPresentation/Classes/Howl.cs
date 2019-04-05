using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    class Howl : ISpeak
    {
        void ISpeak.Speak()
        {
            Console.WriteLine("Hoooooooooooooooooowl!");
        }
    }
}
