using System.Collections.Generic;
using System.Linq;

namespace CandyShop.Models
{
    public class CategoryServiceWithEntity : ICategoryRepository
    {
        public CategoryServiceWithEntity(AppDBContext appDBContext)
        {
            AppDBContext = appDBContext;
        }
        public IEnumerable<Category> AllCategories => AppDBContext.Categories;

        public AppDBContext AppDBContext { get; }

        public string GetCategoryName(int ID)
        {
            return AppDBContext.Categories.Find(ID).CategoryName;
            //return AppDBContext.Categories.FirstOrDefault(c => c.CategoryId == ID).CategoryName;
        }
    }
}
