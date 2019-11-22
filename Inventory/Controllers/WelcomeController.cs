using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
  
    public class WelcomeController : ControllerBase
    {

        // GET: api/Welcome
        [Route("api/Welcome")]
        [HttpGet]
        public ActionResult<String> GetWelcome()
        {
            return "Welcome to Api System Inventory, API running sucessfully";
        }

    }
}