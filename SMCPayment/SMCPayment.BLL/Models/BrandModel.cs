using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCPayment.BLL.Models
{
   public class BrandModel:BaseDomainModel<BrandModel>
    {
        public int brand_id { get; set; }
        public string brand_name { get; set; }
    }
}
