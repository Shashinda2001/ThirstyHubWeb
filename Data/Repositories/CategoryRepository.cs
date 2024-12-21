using System;
using ThirstyHubWeb.Data.Interfaces;
using ThirstyHubWeb.Data.Models;

namespace ThirstyHubWeb.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => throw new NotImplementedException();
    }
}
