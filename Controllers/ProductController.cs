using System;
using HW_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			var datas = GetAllProducts();
			return View(datas);
		}

		private List<Product> GetAllProducts()
		{
			return new List<Product>
			{
				new()
				{
					Id = 1,
					Name = "iPhone",
					Count = 10,
					Description = "Phone",
					Price = 3000
				},
                new()
                {
                    Id = 2,
                    Name = "MacBook",
                    Count = 14,
                    Description = "Notebook",
                    Price = 4000
                },
                new()
                {
                    Id = 3,
                    Name = "AirPods",
                    Count = 34,
                    Description = "Headphones",
                    Price = 400
                },
            };
		}
	}
}

