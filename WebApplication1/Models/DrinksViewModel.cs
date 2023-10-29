using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class DrinksViewModel
    {
        public List<Drink> drinks{ get; set; }
        public DrinksViewModel(List<Drink> drinks)
        {
            this.drinks = drinks;
        }

    }
}
