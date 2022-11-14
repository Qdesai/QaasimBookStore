using QaasimBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QaasimBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
