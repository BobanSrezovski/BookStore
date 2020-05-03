using BookStore.Data.Entities;

namespace BookStore.Services.Service.Interfaces
{
    public interface IEmailService
    {
        void SendMail(Email email);
    }
}
