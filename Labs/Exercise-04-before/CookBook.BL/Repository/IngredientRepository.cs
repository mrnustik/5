using CookBook.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using CookBook.BL.Factories;

namespace CookBook.BL.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IDbContextFactory dbContextFactory;

        public IngredientRepository(IDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public IngredientDetailModel Create(IngredientDetailModel model)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapIngredientModelToEntity(model);
                dbContext.Ingredients.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapIngredientEntityToDetailModel(entity);
            }
        }

        public void Delete(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = dbContext.Ingredients.First(t => t.Id == id);
                dbContext.Ingredients.Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<IngredientListModel> GetAll()
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                return dbContext.Ingredients.Select(Mapper.MapIngredientEntityToListModel);
            }
        }

        public IngredientDetailModel GetById(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = dbContext.Ingredients.First(t => t.Id == id);
                return Mapper.MapIngredientEntityToDetailModel(entity);
            }
        }

        public void Update(IngredientDetailModel model)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapIngredientModelToEntity(model);
                dbContext.Ingredients.Update(entity);
                dbContext.SaveChanges();
            }
        }
    }
}
