
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroVisual.Controllers
{
    [Route("company/[controller]/[action]")]
    public class EmployeeController : Controller
    {

       
            
        public ContentResult Name()
        {
            return Content("Tshimanga");
        }

        public ContentResult Country()
        {
            return Content("South Africa");
        }

        public ContentResult Index()
        {
            return Content("Hello from Employee");
        }
    }
}
