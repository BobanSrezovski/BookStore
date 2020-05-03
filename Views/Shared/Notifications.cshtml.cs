using BookStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BookStore.Views.Shared
{
    public class NotificationsModel : PageModel
    {
        private readonly IShoppingCartService _shoppingCartService;

        public NotificationsModel(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        public void OnGet()
        {
            var notificationCounters = _shoppingCartService.GetAllItemsInCart().Count();

            ViewData["Counter"] = notificationCounters;
        }
    }
}