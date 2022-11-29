using QaasimBooks.DataAccess.Repository.IRepository;
using QaasimBooks.Models;
using QaasimBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QaasimBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)

        {

            var objFromDb = _db.Products.FirstOrDefault(s => s.id == product.id);

            if (objFromDb != null)  // save changes if not null

            {

                if (product.ImageUrl != null)

                {

                    objFromDb.ImageUrl = product.ImageUrl;      // add the check for ImageUrl

                }

                objFromDb.Title = product.Title;

                objFromDb.Description = product.Description;

                objFromDb.ISBN = product.ISBN;

                objFromDb.Author = product.Author;

                objFromDb.ListPrice = product.ListPrice;

                objFromDb.Categoryid = product.Categoryid;

                objFromDb.CoverTypeid = product.CoverTypeid;    // all properties of Product object

            }

        }
    }
}
