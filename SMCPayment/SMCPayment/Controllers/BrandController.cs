using SMCPayment.BLL;
using SMCPayment.BLL.Models;
using SMCPayment.BLL.Services;
using SMCPAyment.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMCPayment.Controllers
{
    [RoutePrefix("Brand")]
    public class BrandController : ApiController
    {
        private readonly IService<brand,BrandModel> _brandService;
        
        public BrandController(IService<brand, BrandModel> brandService)
        {
            _brandService = brandService;
        }

        
        [HttpGet]
        [Route("GetBrandList")]
        public HttpResponseMessage GetBrandList()
        {
            try
            {
                var list= _brandService.GetAll().ToList();
                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch (Exception ex)
            {

                // throw;
               return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
             
        }
    }
}
