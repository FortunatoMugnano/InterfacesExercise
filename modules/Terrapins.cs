using System;

namespace InterfaceExercise
{
    public class Terrapins : ISwimming, IWalking
    {
        public int MaximumDepth { get; set; }

        public void Run()
        {
            Console.WriteLine("I can't run, I am a turtle!");
        }

        public void Swim()
        {
            Console.WriteLine("Finding Nemo");
        }

        public void Walk()
        {
            Console.WriteLine("I walk veeeery slow");
        }
    }
}