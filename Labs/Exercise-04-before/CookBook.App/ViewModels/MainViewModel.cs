using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookBook.BL.Factories;
using CookBook.BL.Models;
using CookBook.BL.Repository;

namespace CookBook.App.ViewModels
{
    class MainViewModel
    {

        private readonly IIngredientRepository ingredientRepository = new IngredientRepository(new DbContextFactory());

        public IngredientDetailModel Detail { get; set; }

        public void Load()
        {
            Detail = ingredientRepository.GetById(new Guid("5abdfee1-c970-4afd-aff8-aa3cfef8b1ac"));
        }
    }
}
