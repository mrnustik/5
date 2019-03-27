using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.BL.Models
{
    public class IngredientDetailModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
