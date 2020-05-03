using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Services.Service.Interfaces
{
    public interface IWishlistService
    {
        void Add(Wishlist wishlist);
        void Edit(Wishlist wishlist);
        void Delete(int id);
        void DeleteByBookId(int bookID);
        Wishlist GetWishlistById(int id);
        Wishlist GetWishlistByBookId(int bookID);
        IEnumerable<Wishlist> GetAllWishlists();
        IEnumerable<Wishlist> GetAllWishlistByUserId(string userId);
    }
}
