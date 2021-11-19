using Mod2HW3.Helper;
using Mod2HW3.Services.Abstractions;

namespace Mod2HW3.Services
{
    public class WeightService : IWeightService
    {
        public double Value { get; set; }
        public WeightUnits WeightUnits { get; set; }

        public double GetWeight()
        {
            return Value * GetGrams();
        }

        public double GetGrams()
        {
            switch (WeightUnits)
            {
                case WeightUnits.G:
                    return 1.0d;
                case WeightUnits.Kg:
                    return 1000.0d;
                default:
                    return 0.0d;
            }
        }
    }
}