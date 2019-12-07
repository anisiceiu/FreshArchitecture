using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMCPAyment.DAL.Repository;
using SMCPAyment.DAL.Models;
using SMCPayment.BLL.Models;
using SMCPayment.BLL.Services;
using SMCPAyment.DAL;

namespace SMCPayment.BLL
{
    public interface ICustomerService : IBusinessService<CustomerModel,customer>
    {
    }
  public  class CustomerService : Service<CustomerModel,customer>, ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) :base(customerRepository)
        {
            _customerRepository = customerRepository; 
        }

        
    }
}
