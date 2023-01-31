using Microsoft.EntityFrameworkCore;
using P04Sklep.API.Data;
using P05Sklep.Shared;
using P06Sklep.DataSeeder;

namespace P04Sklep.API.Services.ProductService
{
    
    public class ProductService : IProductService
    {

        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceReponse<Product[]>> GetProductAsync()
        {
            var response = new ServiceReponse<Product[]>()
            {
                Data = await _context.Products.ToArrayAsync()
            };

            return response;

            // odwołanie do DataContext (baza danych) 
            //var data = new Product[2]
            //{
            //    new Product()
            //    {
            //        Id =1,
            //        Title="Product 1",
            //        Description = "Desc 1",
            //    }, new Product()
            //    {
            //        Id =2,
            //        Title="Product 2",
            //        Description = "Desc 2",
            //    }
            //};


            //var response = new ServiceReponse<Product[]>()
            //{
            //    Data = ProductSeeder.GenerateProductData()
            //};
            //return response;


        }

        public async Task<ServiceReponse<Product>> UpdateProduct(Product product)
        {
            var p = _context.Products.FirstOrDefault(x=>x.Id == product.Id);

            if (p == null)
            {
                return new ServiceReponse<Product>
                {
                    Success = false,
                    Message = "Not found product"
                };
            }

            p.Title = product.Title;
            p.Description = product.Description;
            p.Color = product.Color;
            p.ImageUrl = product.ImageUrl;

            await _context.SaveChangesAsync();

            return new ServiceReponse<Product>() { Data = product };

        }
    }
}
