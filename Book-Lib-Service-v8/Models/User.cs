using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Lib_Service_v8.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Friends { get; set; }
        public ICollection<Book> BooksRead { get; set; }
    }
}
