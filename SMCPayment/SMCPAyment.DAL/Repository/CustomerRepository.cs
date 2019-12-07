using SMCPAyment.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPAyment.DAL.Repository
{
    public interface ICustomerRepository:IRepository<customer>
        
    {

    }
    public class CustomerRepository : Repository<customer>, ICustomerRepository
    {
        public CustomerRepository()
        {

        }

    }
}
