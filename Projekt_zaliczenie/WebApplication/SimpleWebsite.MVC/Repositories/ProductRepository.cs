using SimpleWebsite.MVC.Data;
using SimpleWebsite.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebsite.MVC.Repositories
{
    public class ProductRepository
    {
        private readonly SimpleWebsiteMVCContext _context;

        public ProductRepository(SimpleWebsiteMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Product.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        public async Task<List<Product>> GetProductsBySearchString(string searchString)
        {
            return await _context.Product
                .Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString))
                .ToListAsync();
        }
    }
}

