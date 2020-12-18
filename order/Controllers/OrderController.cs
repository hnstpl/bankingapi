using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace order.Controllers
{
    public class OrderController : Controller
    {
        // GET: api/values
        [AllowAnonymous]
        [Route("order")]
        [Route("order/get")]
        [HttpGet("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "order 1", "order 2" };
        }
    }
}
