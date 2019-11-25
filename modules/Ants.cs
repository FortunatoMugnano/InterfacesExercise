using System;

namespace InterfaceExercise
{
    public class Ants : IWalking, IDigging
    {
        public int MaximumDeep { get; set; }

        public void Dig()
        {
            Console.WriteLine("I dig to hide from humans");
        }

        public void Run()
        {
            Console.WriteLine("I run very fast!");
        }

        public void Walk()
        {
            Console.WriteLine("I walk with other ants");
        }
    }
}