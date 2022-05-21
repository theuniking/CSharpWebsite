using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.wwwroot.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
        public string desc { get; set; }
        public List<Book> books { set; get; }
    }
}
