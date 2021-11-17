using Mod2HW3.Helper;

namespace Mod2HW3.Layer1
{
    public abstract class SugarSweets : SweetStuff
    {
        public SugarType SugarType { get; set; }
        public Ingredients[] Ingredients { get; set; }
    }
}