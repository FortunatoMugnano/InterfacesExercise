using System;

namespace InterfaceExercise
{
    public class BettaFishes : ISwimming, IFlying
    {
        public int MaximumDepth { get; set; }
        public int MaximumHigh { get; set; }

        public void Fly()
        {
            Console.WriteLine("I fly out of the water!");
        }

        public void Swim()
        {
            Console.WriteLine("I love to swim in hot water");
        }
    }
}