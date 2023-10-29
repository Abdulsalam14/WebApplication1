using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        List<Drink> drinks = new() {

            new Drink()
            {
                Id = 1,
                Name="Drink1",
                Price=11
            },
            new Drink()
            {
                Id = 2,
                Name="Drink2",
                Price=12
            },
            new Drink()
            {
                Id = 3,
                Name="Drink3",
                Price=13
            },

        };

        List<FastFood> fastfoods = new() {

            new FastFood()
            {
                Id = 1,
                Name="Fastfood1",
                Price=31,
                Calory=100
            },
            new FastFood()
            {
                Id = 2,
                Name="Fastfood2",
                Price=32,
                Calory=200

            },
            new FastFood()
            {
                Id = 3,
                Name="Fastfood3",
                Price=33,
                Calory=300

            },

        };

        List<Hotmeal> hotmeals = new() {

            new Hotmeal()
            {
                Id = 1,
                Name="HotMeal1",
                Price=21,
                Description="HotMeal1Description"
            },
            new Hotmeal()
            {
                Id = 2,
                Name="HotMeal2",
                Price=22,
                Description="HotMeal2Description"

            },
            new Hotmeal()
            {
                Id = 3,
                Name="HotMeal3",
                Price=23,
                Description="HotMeal3Description"
            },

        };


        public IActionResult Index()
        {
            var viewmodel = new HomeViewModel(drinks, fastfoods, hotmeals);

            return View(viewmodel);
        }


        public IActionResult Drinks()
        {
            var viewmodel = new DrinksViewModel(drinks);
            return View(viewmodel);
        }

        public IActionResult Hotmeals()
        {
            var viewmodel = new HotMealsViewModel
            {
                Hotmeals = hotmeals
            };
            return View(viewmodel);
        }

        public IActionResult Fastfoods()
        {
            var viewmodel = new FastFoodsViewModel
            {
                FastFoods = fastfoods
            };
            return View(viewmodel);
        }
    }
}
