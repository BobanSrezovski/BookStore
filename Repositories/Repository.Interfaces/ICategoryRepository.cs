﻿using BookStore.Data.Entities;
using System.Collections.Generic;

namespace BookStore.Repositories.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Edit(Category category);
        void Delete(int id);
        IEnumerable<Category> GetCategories();
        Category GetCategoryById(int id);
    }
}
