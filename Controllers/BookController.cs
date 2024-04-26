using System;
using HW_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW_ASP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAllProducts();
            return View(datas);
        }



        private List<Book> GetAllProducts()
        {
            return new List<Book>
            {
                new()
                {
                    Id = 1,
                    Name = "Otci i deti",

                },
                  new()
                {
                    Id = 2,
                    Name = "Bratya Karamozovi",

                },
                  new()
                {
                    Id = 3,
                    Name = "Voyna i mir",

                },
            };
        }
    }
}

