using System;

namespace InterfaceExercise
{
    public class TimberRattleSnakes : IWalking, IDigging
    {
        public int MaximumDeep { get; set; }

        public void Dig()
        {
            Console.WriteLine("I dig to hide from humans");
        }

        public void Run()
        {
            Console.WriteLine("I squisssss!!");
        }

        public void Walk()
        {
            Console.WriteLine("I don't have legs!");
        }
    }
}