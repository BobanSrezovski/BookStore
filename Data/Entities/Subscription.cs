using System.ComponentModel.DataAnnotations;

namespace BookStore.Data.Entities
{
    public class Subscription
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string SubscibeTo { get; set; }
        [StringLength(250)]
        public string SubscribeFrom { get; set; }
    }
}
