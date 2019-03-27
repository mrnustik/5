using System;
using System.Collections.Generic;
using System.Text;
using CookBook.BL.Models;
using CookBook.DAL.Entities;

namespace CookBook.BL
{
    class Mapper
    {
        public static IngredientDetailModel MapIngredientEntityToDetailModel(IngredientEntity entity)
        {
            return new IngredientDetailModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }

        public static IngredientListModel MapIngredientEntityToListModel(IngredientEntity entity)
        {
            return new IngredientListModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        public static IngredientEntity MapIngredientModelToEntity(IngredientDetailModel model)
        {
            return new IngredientEntity()
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
