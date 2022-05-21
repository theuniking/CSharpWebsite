using MyCompany.wwwroot.Data.Models;
using System.Collections.Generic;

namespace MyCompany.Data.interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<IBooksCategory> getFavBooks { get; }
        IBooksCategory getObjectByBook(int bookID);
    }
}
