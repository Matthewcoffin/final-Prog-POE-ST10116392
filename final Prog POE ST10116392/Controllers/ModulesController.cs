using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_Prog_POE_ST10116392.Models;

namespace final_Prog_POE_ST10116392.Controllers
{
   
    public class ModulesController : Controller
    {

       
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
