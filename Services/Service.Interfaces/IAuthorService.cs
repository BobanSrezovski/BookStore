using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Services.Service.Interfaces
{
    public interface IAuthorService
    {
        void Add(Author author);
        void Edit(Author author);
        void Delete(Author author);

        IEnumerable<Author> GetAuthors();
        Author GetAuthorById(int id);
        Author GetAuthorByPopularity();
    }
}
