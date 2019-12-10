using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private List<Book> books = new List<Book>();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Book book)
        {
            books.Add(book);
            ViewBag.QuantityBooks = books.Count;
            return View("Books", ViewBag.QuantityBooks);
        }
    }
}