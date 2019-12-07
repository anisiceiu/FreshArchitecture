using SMCPayment.BLL;
using SMCPayment.BLL.Models;
using SMCPayment.BLL.Services;
using SMCPAyment.DAL;
using SMCPAyment.DAL.Models;
using SMCPAyment.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SMCPayment.Controllers
{
    [RoutePrefix("Customer")]
    public class CustomerController : ApiController
    {
      
        private readonly ICustomerService customerService;
        
        public CustomerController(ICustomerService _customerService)
        {
            this.customerService = _customerService;
        }

        
        [HttpGet]
        [Route("GetCustomerList")]
        public List<CustomerModel> GetCustomerList()
        {
            try
            {
                var list = this.customerService.GetAll().ToList();
                // return Request.CreateResponse(HttpStatusCode.OK, list);
                return list;
            }
            catch (Exception ex)
            {
                return null;
                // throw;
               //return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
             
        }
    }
}
