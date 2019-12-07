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
    public interface IBrandService:IBusinessService<BrandModel,brand>
    {
    }
  public  class BrandService:Service<BrandModel,brand>,IBrandService
    {

        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository):base(brandRepository)
        {
            _brandRepository = brandRepository; 
        }

        
    }
}
