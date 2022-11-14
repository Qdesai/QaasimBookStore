using QaasimBooks.DataAccess.Repository.IRepository;
using QaasimBooks.Models;
using QaasimBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace QaasimBooks.DataAccess.Repository
{
    class CategoryRepository  : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
