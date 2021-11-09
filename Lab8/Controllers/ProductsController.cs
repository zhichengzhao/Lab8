using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Lab8.Models;
using System.Threading.Tasks;
namespace Lab8.Controllers
{
    public class ProductsController : ApiController
    {
		Product[] products = new Product[]
		{
			new Product { Id = 1, Name = "Tomato Soup", Category = "Grocer", Price = 10 },
			new Product { Id = 2, Name = "Yoo", Category = "Toys", Price = 3.89M },
			new Product { Id = 3, Name = "Ham", Category = "Hardware", Price = 20.01M }
		};


		public ProductsController()
		{

		}
		public ProductsController(Product[] products)
		{
			this.products = products;
		}

		public IEnumerable<Product> GetAllProducts()
		{
			return products;
		}

		public IHttpActionResult GetProduct(int id)
		{
			var product = products.FirstOrDefault((p) => p.Id == id);
			if (product == null)
			{
				return NotFound();
			}
			return Ok(product);
		}
	}
}
