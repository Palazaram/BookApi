using BookApi.Models.Domain;
using BookApi.Models.DTOs;

namespace BookApi.Repositories.Abstract
{
    public interface IBookRepository
    {
        bool AddUpdate(Book book);

        bool Delete(int id);

        Book GetById(int id);

        IEnumerable<Book> GetAll(string term = "");

        IEnumerable<Statistic> GetBookStatistic();
    }
}
