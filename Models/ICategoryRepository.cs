using System.Collections.Generic;

namespace CandyShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
        string GetCategoryName(int ID);
    }
}
