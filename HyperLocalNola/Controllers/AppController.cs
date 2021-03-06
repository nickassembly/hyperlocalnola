﻿using Microsoft.AspNetCore.Mvc;

namespace HyperLocalNola.Controllers
{

   public class AppController : Controller
   {

      [HttpGet("")]
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet("music")]
      public IActionResult Music()
      {
         return View();
      }

      [HttpGet("products")]
      public IActionResult Products()
      {
         return View();
      }

      [HttpGet("technology")]
      public IActionResult Technology()
      {
         return View();
      }

   }
}
