using Microsoft.AspNetCore.Authorization;

namespace SimpleWebsite.MVC.Models
{
    public class Product
    {
        public int Id { get; set;  }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }

    }
}
