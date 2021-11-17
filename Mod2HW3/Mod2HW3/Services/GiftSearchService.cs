using Mod2HW3.Services.Abstractions;

namespace Mod2HW3.Services
{
    public static class GiftSearchService
    {
        public static string FindByName(this SweetStuff[] sweets, string name)
        {
            foreach (var sweetStuff in sweets)
            {
                if (sweetStuff.Name == name)
                {
                    return sweetStuff.Name;
                }
            }

            return null;
        }
    }
}