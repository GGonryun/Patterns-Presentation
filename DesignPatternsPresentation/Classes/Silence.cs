
using System;

namespace DesignPatternsPresentation.Classes
{
    internal class Silence : ISpeak
    {
        void ISpeak.Speak()
        {
            Console.WriteLine("...");
        }
    }
}