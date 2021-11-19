using System;
using Mod2HW3.Helper;
using Mod2HW3.Services.Abstractions;

namespace Mod2HW3.Services
{
    public class GiftService : IGiftService
    {
        private double _weight = 0.0d;
        public SweetStuff[] AddToTheGift(SweetStuff[] sweetStuffs)
        {
            var sweetsAtTheGift = new SweetStuff[sweetStuffs.Length];
            for (var i = 0; i < sweetStuffs.Length; i++)
            {
                sweetsAtTheGift[i] = sweetStuffs[i];
            }

            return sweetsAtTheGift;
        }

        public double GetGiftWeight(SweetStuff[] candies)
        {
            foreach (var candy in candies)
            {
                _weight += candy.Weight.Value;
            }

            return _weight;
        }

        public SweetStuff[] SortSweets(SweetStuff[] sweets)
        {
            Array.Sort(sweets, new SweetsComparer());
            return sweets;
        }

        public void WriteGiftContents(SweetStuff[] candies)
        {
            foreach (var candy in candies)
            {
                Console.WriteLine($"{candy.Name}: {candy.Weight.Value}{candy.Weight.WeightUnits}");
            }
        }

        public void WriteGiftWeight(double weight)
        {
            Console.WriteLine($"Gift`s weight is: {weight}{WeightUnits.G}");
        }

        public void WriteFoundCandy(string candy)
        {
            Console.WriteLine($"We found candy that you were looking for: {candy}");
        }
    }
}