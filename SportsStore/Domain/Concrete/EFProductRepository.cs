﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstract;
using Domain.Entities;


//talk to the database
namespace Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context= new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
       
    }
}
