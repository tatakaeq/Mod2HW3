using System;
using Mod2HW3.Providers;
using Mod2HW3.Services;
using Mod2HW3.Services.Abstractions;

namespace Mod2HW3
{
    public class Starter
    {
        private readonly IGiftService _giftService;
        private readonly ISweetsProvider _sweetStuffProvider;
        private double _giftWeight;
        private SweetStuff[] _gift;

        public Starter()
        {
            _giftService = new GiftService();
            _sweetStuffProvider = new SweetStuffProvider();
        }
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