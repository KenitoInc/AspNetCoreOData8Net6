using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Lib_Service_v8.Models
{
    // Book
    public class Book
    {
        public decimal Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public Address Location { get; set; }
        public Press Press { get; set; }
    }

    // Press
    public class Press
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Category Category { get; set; }
    }

    // Category
    public enum Category
    {
        Book,
        Magazine,
        EBook
    }

    // Address
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public PostalAddress Postal { get; set; }
    }

    // Postal Address
    public class PostalAddress
    {
        public string Box { get; set; }
        public string PostalCode { get; set; }
    }
}
