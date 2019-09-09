using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data;
using ProductCatalog.Models;
using ProductCatalog.ViewModels.ProductViewModels;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private readonly StoreDataContext _context;
        public ProductController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("v1/products")]
        [HttpGet]
        public IEnumerable<ListProductViewModel> Get()
        {
            return _context.Products
                .Include(x => x.category)
                .Select(x => new ListProductViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    Price = x.Price,
                    Category = x.category.Title,
                    CategoyId = x.category.id
                })
                .AsNoTracking()
                .ToList();
        }
        
        [Route("v1/products/{id}")]
        [HttpGet]
        public Product Get(int id)
        {
            return _context.Products.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        [Route("v1/products")]
        [HttpGet]
        public ResultViewModel Post([FromBody]EditorProductViewModel model)
        {
            model.Validate();
            if(model.invalid)
            {
                Success = false,
                Message = "Não foi possivel cadastrar o Produto",
                Data = model.Notifications
            };

            var product = new Product();
            product.Title = model.Title;
            product.CategoyId = model.CategoyId;
            product.CreateDate = DateTime.Now;
            product.Description = model.Description;
            product.Image = model.Image;
            product.LastUpdateDate = DateTime.Now;
            product.Quantity = model.Quantity;

            _context.Products.Add(product);
            _context.SaveChanges();

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto cadastrado com sucesso",
                Data = product
            };
        }

        [Route("v1/products")]
        [HttpPut]
        public ResultViewModel put([FromBody]EditorProductViewModel model)
        {
            model.Validate();
            if(model.Invalid)
                return new ResultViewModel
                {
                    Success = false,
                    Message = "Não foi possivel alterar o produto",
                    Data = model.Notifications
                };

            var products = _context.Products.Find(model.id);
            products.Title = model.Title;
            products.CategoyId = model.CategoyId;
            //products.CreateDate = DateTime.Now;
            products.Description = model.Description;
            products.Image = model.Image;
            products.LastUpdateDate = DateTime.Now;
            products.Price = model.Price;
            products.Quantity = model.Quantity;

            _context.Entry<Product>(products).State = EntityState.Modified;
            _context.SaveChanges();

            return new ResultViewModel
            {
                Success = true,
                Message = "Produto alterado com sucesso!",
                Data = products
            }

        }
    }
}