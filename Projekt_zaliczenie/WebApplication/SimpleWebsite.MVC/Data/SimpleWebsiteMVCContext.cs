using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebsite.MVC.Models;

namespace SimpleWebsite.MVC.Data
{
    public class SimpleWebsiteMVCContext : DbContext
    {
        public SimpleWebsiteMVCContext (DbContextOptions<SimpleWebsiteMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleWebsite.MVC.Models.Product> Product { get; set; } = default!;
    }
}
