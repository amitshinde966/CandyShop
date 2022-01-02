using System.Collections.Generic;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}
