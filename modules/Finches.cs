using System;

namespace InterfaceExercise
{
    public class Finches : IFlying
    {
        public int MaximumHigh { get; set; }

        public void Fly()
        {
            Console.WriteLine("You can Fly!!!!!");
        }
    }
}