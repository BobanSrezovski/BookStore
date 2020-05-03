using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Repositories.Repository.Interfaces
{
    public interface ISearchRepository
    {
        IEnumerable<Book> SearchBooks(List<string> keywords, string title, string author, string category);
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
    }
}
