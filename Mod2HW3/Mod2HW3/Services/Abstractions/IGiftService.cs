namespace Mod2HW3.Services.Abstractions
{
    public interface IGiftService
    {
        SweetStuff[] AddToTheGift(SweetStuff[] sweetStuffs);
        double GetGiftWeight(SweetStuff[] candies);
        SweetStuff[] SortSweets(SweetStuff[] candies);
        void WriteGiftContents(SweetStuff[] candies);
        void WriteGiftWeight(double weight);
        void WriteFoundCandy(string candy);
    }
}