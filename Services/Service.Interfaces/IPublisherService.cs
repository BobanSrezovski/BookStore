using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Services.Service.Interfaces
{
    public interface IPublisherService
    {
        void Add(Publisher publisher);
        void Edit(Publisher publisher);
        void Delete(int id);
        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisherById(int id);
    }
}
