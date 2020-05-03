namespace BookStore.Models
{
    public class BaseModel
    {
        public BookViewModel BookViewModel { get; set; }
        public BookSearchViewModel BookSearchViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public PublisherViewModel PublisherViewModel { get; set; }
        public ShopCartViewModel ShopCartViewModel { get; set; }
        public UserViewModel UserViewModel { get; set; }
        public WishListViewModel WishListViewModel { get; set; }
    }
}
