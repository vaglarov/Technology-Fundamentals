using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {   
        public IActionResult Index()
        {
            using (var db = new BookDb())
            {
                var books= db.Books.ToList();
                return this.View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            using (var db = new BookDb())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new BookDb())
            {
                Book book = db.Books.Find(id);
                return View(book);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            using (var db = new BookDb())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new BookDb())
            {
                Book book = db.Books.Find(id);
                return View(book);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new BookDb())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}