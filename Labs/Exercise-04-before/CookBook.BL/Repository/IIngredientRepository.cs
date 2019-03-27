using CookBook.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.BL.Repository
{
    public interface IIngredientRepository
    {
        IngredientListModel GetAll();
        IngredientDetailModel GetById(Guid id);
        IngredientDetailModel Create(IngredientDetailModel model);
        void Update(IngredientDetailModel model);
        void Delete(Guid id);
    }
}
