using System;
using HW_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP.Controllers
{
	public class UserController : Controller
	{
        public IActionResult Index()
        {
            var datas = GetAllProducts();
            return View(datas);
        }

        private List<User> GetAllProducts()
        {
            return new List<User>
            {
                new()
                {
                    Id = 1,
                    FullName = "Elnur Safiyev",
                    Address = "Nesimi",
                    Age = 19
                },
                new()
                {
                    Id = 2,
                    FullName = "Ali Aliyev",
                    Address = "Yasamal",
                    Age = 29
                },
            };
        }

    }
}

