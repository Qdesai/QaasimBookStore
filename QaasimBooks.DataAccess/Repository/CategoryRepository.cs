﻿using QaasimBooks.DataAccess.Repository.IRepository;
using QaasimBooks.Models;
using QaasimBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var objFromDb = _db.Categories.FirstOrDefault(s => s.id == category.id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
