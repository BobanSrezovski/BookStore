using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class PublisherViewModel
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Country { get; set; }
    }
}
