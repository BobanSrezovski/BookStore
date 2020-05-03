using System.ComponentModel.DataAnnotations;

namespace BookStore.Data.Entities
{
    public class Subcategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }
    }
}
