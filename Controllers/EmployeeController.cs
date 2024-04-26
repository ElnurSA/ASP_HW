using System;
using HW_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP.Controllers
{
	public class EmployeeController : Controller
	{
        public IActionResult Index()
        {
            var datas = GetAllProducts();
            return View(datas);
        }



        private List<Employee> GetAllProducts()
        {
            return new List<Employee>
            {
                new()
                {
                    Id = 1,
                    Name = "Elnur",
                    Surname = "Safiyev",
                    Salary = 1000,
                    Age = 19
                },
                new()
                {
                    Id = 2,
                    Name = "Ali",
                    Surname = "Aliyev",
                    Salary = 3000,
                    Age = 29
                },
            };
        }
    }
}

