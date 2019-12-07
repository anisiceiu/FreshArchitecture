using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMCPAyment.DAL.Models;

namespace SMCPAyment.DAL.Repository
{
    public interface IBrandRepository : IRepository<brand>
    {

    }

   public  class BrandRepository:Repository<brand>,IBrandRepository
    {
        public BrandRepository()
        {

        }
       
    }
}
