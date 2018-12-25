using FirstWebApp.Data;
using FirstWebApp.Models;
using FirstWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstWebApp.UnitOfWork
{
    public class UnitOfWorkApp : DbContext
    {
        ContextApp context = new ContextApp();
        Repository<Product> productRepository;

        public Repository<Product> ProductRepository
        {
            get
            {
                if(productRepository == null)
                {
                    productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}