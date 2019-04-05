using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsPresentation.Classes
{
    class Bark : ISpeak
    {
        void ISpeak.Speak()
        {
            Console.WriteLine("Bark!");
        }
    }
}
