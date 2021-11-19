using Mod2HW3.Helper;
using Mod2HW3.Services;

namespace Mod2HW3
{
    public abstract class SweetStuff
    {
        public string Name { get; set; }
        public WeightService Weight { get; set; }
    }
}