using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        public HomeViewModel(List<Drink> drinks, List<FastFood> fastFoods, List<Hotmeal> hotmeals)
        {
            Drinks = drinks;
            FastFoods = fastFoods;
            Hotmeals = hotmeals;
        }

        public List<Drink>  Drinks { get; set; }

        public List<FastFood> FastFoods { get; set; }

        public List<Hotmeal> Hotmeals { get; set; }


    }
}
