﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineTicariOtomasyon.Models.Classes;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Products.Where(x => x.ProductId == 1).ToList();
            return View(result);
        }
    }
}