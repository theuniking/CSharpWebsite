using Microsoft.AspNetCore.Mvc;
using MyCompany.Data.interfaces;
using MyCompany.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class BooksController: Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;
        public BooksController(IAllBooks iAllBooks,IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }
        public ViewResult List(string category)
        {
            BooksListViewModel obj = new BooksListViewModel();
            obj.allBooks = _allBooks.Books;
            obj.currCategory = "Книги";
            return View(obj);
        }
    }
}
