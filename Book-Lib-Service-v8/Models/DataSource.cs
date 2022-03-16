using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Lib_Service_v8.Models
{
    public static class DataSource
    {
        private static IList<Book> _books { get; set; }

        public static IList<Book> GetBooks()
        {
            if (_books != null)
            {
                return _books;
            }

            _books = new List<Book>();

            // book #1
            Book book = new Book
            {
                Id = 1,
                ISBN = "978-0-321-87758-1",
                Title = "Essential C#5.0",
                Author = "Mark Michaelis",
                Price = 59.99m,
                Location = new Address 
                { 
                    City = "Redmond", Street = "156TH AVE NE",
                    Postal = new PostalAddress { Box = "1234", PostalCode = "00100" }
                },
                Press = new Press
                {
                    Id = 1,
                    Name = "Addison-Wesley",
                    Category = Category.Book
                }
            };
            _books.Add(book);

            // book #2
            book = new Book
            {
                Id = 2,
                ISBN = "063-6-920-02371-5",
                Title = "Enterprise Games",
                Author = "Michael Hugos",
                Price = 49.99m,
                Location = new Address 
                { 
                    City = "Bellevue", Street = "Main ST",
                    Postal = new PostalAddress { Box = "5554", PostalCode = "00200" }
                },
                Press = new Press
                {
                    Id = 2,
                    Name = "O'Reilly",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #3
            book = new Book
            {
                Id = 3,
                ISBN = "999-6-920-02371-5",
                Title = "Purple Hibiscus",
                Author = "Chimamanda Ngozi",
                Price = 49.99m,
                Location = new Address 
                { 
                    City = "Abuja", Street = "Main ST",
                    Postal = new PostalAddress { Box = "31846", PostalCode = "00800" }
                },
                Press = new Press
                {
                    Id = 3,
                    Name = "Macmillan",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #4
            book = new Book
            {
                Id = 4,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Chinua Achebe",
                Price = 49.99m,
                Location = new Address 
                { 
                    City = "Lagos", Street = "Main ST",
                    Postal = new PostalAddress { Box = "97984", PostalCode = "00500" }
                },
                Press = new Press
                {
                    Id = 4,
                    Name = "Lagos publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #5
            book = new Book
            {
                Id = 5,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Ngugi wa thiongo",
                Price = 49.99m,
                Location = new Address
                {
                    City = "Nairobi",
                    Street = "Moi Avenue",
                    Postal = new PostalAddress { Box = "1314", PostalCode = "90500" }
                },
                Press = new Press
                {
                    Id = 5,
                    Name = "ABC publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #6
            book = new Book
            {
                Id = 6,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Chinua Achebe",
                Price = 49.99m,
                Location = new Address
                {
                    City = "Lagos",
                    Street = "Main ST",
                    Postal = new PostalAddress { Box = "97984", PostalCode = "00500" }
                },
                Press = new Press
                {
                    Id = 6,
                    Name = "Lagos publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #7
            book = new Book
            {
                Id = 7,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Chinua Achebe",
                Price = 49.99m,
                Location = new Address
                {
                    City = "Lagos",
                    Street = "Main ST",
                    Postal = new PostalAddress { Box = "97984", PostalCode = "00500" }
                },
                Press = new Press
                {
                    Id = 7,
                    Name = "Lagos publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #8
            book = new Book
            {
                Id = 8,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Chinua Achebe",
                Price = 49.99m,
                Location = new Address
                {
                    City = "Lagos",
                    Street = "Main ST",
                    Postal = new PostalAddress { Box = "97984", PostalCode = "00500" }
                },
                Press = new Press
                {
                    Id = 8,
                    Name = "Lagos publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            // book #9
            book = new Book
            {
                Id = 9,
                ISBN = "777-6-920-02371-5",
                Title = "Things fall apart",
                Author = "Chinua Achebe",
                Price = 49.99m,
                Location = new Address
                {
                    City = "Lagos",
                    Street = "Main ST",
                    Postal = new PostalAddress { Box = "97984", PostalCode = "00500" }
                },
                Press = new Press
                {
                    Id = 9,
                    Name = "Lagos publishers",
                    Category = Category.EBook,
                }
            };
            _books.Add(book);

            return _books;
        }
    }
}
