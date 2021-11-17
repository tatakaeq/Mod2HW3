using Mod2HW3.Helper;

namespace Mod2HW3.Layer1.Layer2.Layer3
{
    public abstract class Сonfectionery : SugarSweets
    {
        public FlourType FlourType { get; set; }
        public Peculiarities Peculiarities { get; set; }
        public DoughType DoughType { get; set; }
    }
}