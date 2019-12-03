using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMCPAyment.DAL.Repository;
using SMCPAyment.DAL.Models;
using SMCPayment.BLL.Models;
using SMCPayment.BLL.Services;

namespace SMCPayment.BLL
{
    public interface IBrandService:IService<brand,BrandModel>
    {

    }
  public  class BrandService:Service<brand,BrandModel>
    {

        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository) :base(new BrandRepository())
        {
            _brandRepository = brandRepository;  
        }
    }
}
