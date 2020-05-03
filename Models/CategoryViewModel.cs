using BookStore.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public List<Subcategory> Subcategory { get; set; }
    }
}
