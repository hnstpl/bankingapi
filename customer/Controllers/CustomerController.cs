using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace customer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: api/values
        [Route("customer")]
        [Route("customer/get")]
        [HttpGet("")]
        public IEnumerable<string> GetCustomers()
        {
            return new string[] { "Customer 1", "Customer 2" };
        }
    }
}
