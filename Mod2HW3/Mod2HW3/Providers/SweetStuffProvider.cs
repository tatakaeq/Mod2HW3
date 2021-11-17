using Mod2HW3.Helper;
using Mod2HW3.Layer1.Layer2.Layer3.Layer4;
using Mod2HW3.Services;

namespace Mod2HW3.Providers
{
    public class SweetStuffProvider : ISweetsProvider
    {
        private static readonly SweetStuff[] _sweets;

        static SweetStuffProvider()
        {
            _sweets = new SweetStuff[]
            {
                new Cake
                {
                    Name = "Honey Cake",
                    Weight = new WeightService { Value = 300, WeightUnits = WeightUnits.G },
                    SugarType = SugarType.CaneSugar,
                    Ingredients = new[] { Ingredients.Cream, Ingredients.Eggs, Ingredients.Milk, Ingredients.Yeast, Ingredients.Flour },
                    CakeType = CakeTypes.ButterCake,
                    CreamType = CreamType.WhippedCream,
                    DoughType = DoughType.UnleavenedDough,
                    FlourType = FlourType.AllPurposeFlour,
                    Peculiarities = Peculiarities.WithoutGMO
                },
                new Bar
                {
                    Name = "Milka",
                    Weight = new WeightService { Value = 70, WeightUnits = WeightUnits.G },
                    SugarType = SugarType.CaneSugar,
                    Ingredients = new[] { Ingredients.Cacao, Ingredients.Milk },
                    ChocolateType = ChocolateType.Milk,
                    ChocolateBarType = ChocolateBarType.Default,
                    Peculiarities = Peculiarities.WithoutGMO
                },
                new Cookie
                {
                    Name = "Lovita",
                    Weight = new WeightService { Value = 100, WeightUnits = WeightUnits.G },
                    SugarType = SugarType.CaneSugar,
                    Ingredients = new[] { Ingredients.Eggs, Ingredients.Cream, Ingredients.Cacao },
                    FlourType = FlourType.AllPurposeFlour,
                    DoughType = DoughType.UnleavenedDough,
                    Peculiarities = Peculiarities.WithoutGMO,
                    Form = Form.Star,
                    CookieFiller = CookieFiller.ChocolatePieces
                },
                new Marmalade()
                {
                    Name = "Haribo",
                    Weight = new WeightService { Value = 100, WeightUnits = WeightUnits.G },
                    SugarType = SugarType.Fructose,
                    Ingredients = new[] { Ingredients.FruitJuice },
                    Peculiarities = Peculiarities.Vegetarian,
                    Thickener = Thickener.Gelatin,
                    MarmaladeTastes = MarmaladeTastes.Apple
                }
            };
        }

        public SweetStuff[] GetSweets()
        {
            return _sweets;
        }
    }
}