﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ventas.Areas.Principal.Controllers
{
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}