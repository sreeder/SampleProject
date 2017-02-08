﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Abstract;
using Domain.Entitities;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;
        // GET: Product
        public ProductController(IProductRepository productRepository)
        {
            this.repository = productRepository;
        }

        //public ViewResult List()
        //{
        //    return View(repository.Products);
        //}

        public ViewResult List(int page = 1)
        {
            return View(repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize));
            
        }
    }
}