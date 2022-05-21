using MyCompany.wwwroot.Data.Models;
using System.Collections.Generic;

namespace MyCompany.Data.interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
