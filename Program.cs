using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var ant1 = new Ants() { MaximumDeep = 2 };
            var bettaFish1 = new BettaFishes() { MaximumDepth = 5, MaximumHigh = 1 };
            var copperHeadSnake1 = new CopperHeadSnakes() { MaximumDeep = 4 };
            var earthWorm1 = new EarthWorms() { MaximumDeep = 5 };
            var finch1 = new Finches() { MaximumHigh = 20 };
            var gerbil1 = new Gerbils() { MaximumDeep = 2 };
            var mice1 = new Mice() { MaximumDeep = 1 };
            var parakeet1 = new Parakeets() { MaximumHigh = 19 };
            var terrapin1 = new Terrapins() { MaximumDepth = 4 };
            var timberRattleSnake1 = new TimberRattleSnakes() { MaximumDeep = 7 };

            List<ISwimming> AnimalsInAquarium = new List<ISwimming>()
            {
                bettaFish1,
                terrapin1
            };
            List<IFlying> myCage = new List<IFlying>()
            {
                finch1,
                parakeet1
            };
            List<IDigging> myGroundCage = new List<IDigging>()
            {
                ant1,
                copperHeadSnake1,
                earthWorm1,
                mice1,
                timberRattleSnake1,
                gerbil1
            };

            List<IDigging> digginsAnimals = new List<IDigging>()
            {
                ant1,
                copperHeadSnake1,
                earthWorm1,
                mice1,
                timberRattleSnake1
            };
            List<IFlying> flyingAnimals = new List<IFlying>()
            {
                bettaFish1,
                finch1,
                parakeet1
            };
            List<ISwimming> swimmingAnimals = new List<ISwimming>()
            {
                bettaFish1,
                terrapin1
            };
            List<IWalking> walkingAnimals = new List<IWalking>()
            {
                ant1,
                copperHeadSnake1,
                gerbil1,
                mice1,
                terrapin1,
                terrapin1
            };

        }
    }
}