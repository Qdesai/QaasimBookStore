using System;
using System.Collections.Generic;
using System.Text;
using QaasimBooks.Models;

namespace QaasimBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
