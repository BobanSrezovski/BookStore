﻿using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Repositories.Repository.Interfaces
{
    public interface IWishlistRepository
    {
        void Add(Wishlist wishlist);
        void Edit(Wishlist wishlist);
        void Delete(int id);
        IEnumerable<Wishlist> GetAllWishlists();
        Wishlist GetWishlistById(int id);


        Wishlist GetWishlistByBookId(int bookID);
        void DeleteByBookId(int bookID);

        // Important
        IEnumerable<Wishlist> GetAllWishlistByUserId(string userId);
    }
}
