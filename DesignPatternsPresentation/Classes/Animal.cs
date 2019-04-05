using System;

namespace DesignPatternsPresentation.Classes
{
    public class Animal
    {
        ISpeak speak;
        IMove move;

        public Animal(ISpeak speakBehaviour, IMove moveBehaviour)
        {
            this.speak = speakBehaviour;
            this.move = moveBehaviour;
        }

        public void SetSpeech(ISpeak speak)
        {
            this.speak = speak;
        }

        public void SetMovement(IMove move)
        {
            this.move = move;
        }

        public void Move()
        {
            move.Move();
        }

        public void Speak()
        {
            speak.Speak();
        }
    }
}
