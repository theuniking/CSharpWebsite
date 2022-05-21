using MyCompany.Data.interfaces;
using MyCompany.wwwroot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Орыс", desc = "Категория русская классика Огромная библиотека электронных книг для онлайн чтения."},
                    new Category { categoryName = "Қазақ", desc = "Категория русская классика Огромная библиотека электронных книг для онлайн чтения."}
                };
            }
        }
    }
}
