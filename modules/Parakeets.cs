using System;

namespace InterfaceExercise
{
    public class Parakeets : IFlying
    {
        public int MaximumHigh { get; set; }

        public void Fly()
        {
            Console.WriteLine("You can Fly!!!!!");
        }
    }
}