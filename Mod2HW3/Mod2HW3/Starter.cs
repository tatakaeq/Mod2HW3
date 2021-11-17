using System;
using Mod2HW3.Providers;
using Mod2HW3.Services;

namespace Mod2HW3
{
    public class Starter
    {
        private readonly GiftService _giftService = new();
        private readonly SweetStuffProvider _sweetStuffProvider = new();
        private double _giftWeight = 0.0d;
        private SweetStuff[] _gift;
        public void Run()
        {
            _gift = _giftService.AddToTheGift(_sweetStuffProvider.GetSweets());
            _giftWeight = _giftService.GetGiftWeight(_gift);
            _giftService.WriteGiftContents(_giftService.SortSweets(_gift));
            _giftService.WriteGiftWeight(_giftWeight);
            _giftService.WriteFoundCandy(_gift.FindByName(_gift[3].Name));
        }
    }
}