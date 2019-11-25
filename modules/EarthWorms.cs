using System;

namespace InterfaceExercise
{
    public class EarthWorms : IDigging
    {
        public int MaximumDeep { get; set; }

        public void Dig()
        {
            Console.WriteLine("Digging very deep!");
        }
    }
}