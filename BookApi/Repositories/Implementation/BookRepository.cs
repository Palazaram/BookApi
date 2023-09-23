using BookApi.Models.Domain;
using BookApi.Models.DTOs;
using BookApi.Repositories.Abstract;
using System.IO;
using System.Linq;

namespace BookApi.Repositories.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly DatabaseContext _db;

        public BookRepository(DatabaseContext bookRepository)
        {
            _db = bookRepository;
        }

        public bool AddUpdate(Book book)
        {
            try
            {
                if (book.Id == 0)
                {
                    _db.Book.Add(book);
                }
                else
                {
                    _db.Book.Update(book);
                }
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var book = GetById(id);

                if (book == null)
                {
                    return false;
                }
                _db.Book.Remove(book);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Book> GetAll(string term = "")
        {
            if (term == null)
            {
                term = "";
                term = term.ToLower();
            }
            else
            {
                term = term.ToLower();
            }

            var data = (from book in _db.Book
                        where term == "" || book.Title.ToLower().StartsWith(term)
                        select new Book
                        {
                            Id = book.Id,
                            Title = book.Title,
                            CreatedAt = book.CreatedAt,
                            Description = book.Description,
                            PageCount = book.PageCount
                        }).ToList();


            return data;
        }

        public Book GetById(int id)
        {
            return _db.Book.Find(id);
        }


        public IEnumerable<Statistic> GetBookStatistic() 
        {
            var bookStatistics = _db.Book.GroupBy(book => book.CreatedAt.Year)
                                .Select(group => new Statistic
                                {
                                    Year = group.Key.ToString(),
                                    BookCount = group.Count()
                                })
                                .ToList();
            return bookStatistics;
        }
    }
}
