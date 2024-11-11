using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Project.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        // Danh sách các cuốn sách (nhớ using System.Collections Generic)
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/book/images.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 2,
                    Title = "Tấm cám",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/book/images.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 3,
                    Title = "Vĩnh dạ tinh hà",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/book/images.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
            };
            return books;
        }

        // Chi tiết 1 cuốn sách theo id (nhớ using System.Linq)
        public Book GetBookId(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        // SelectListItem Authors (using Microsoft.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value = "1", Text = "Nam Cao" },
            new SelectListItem {Value = "2", Text = "Nam Cao" },
            new SelectListItem {Value = "3", Text = "Nam Cao" },
            new SelectListItem {Value = "4", Text = "Nam Cao" },
        };

        // SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem {Value = "1", Text = "Truyện tranh" },
            new SelectListItem {Value = "2", Text = "Truyện tranh" },
            new SelectListItem {Value = "3", Text = "Truyện tranh" },
            new SelectListItem {Value = "4", Text = "Phim hài hước" },
        };
    }
}
