﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slashroll.Controllers
{
    public class RollController : Controller
    {

        public ActionResult Roll(string room)
        {
            return View();
        }
    }
}