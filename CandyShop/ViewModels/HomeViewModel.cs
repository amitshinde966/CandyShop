using CandyShop.Models;
using System.Collections.Generic;

namespace CandyShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandiesOnSale { get; set; }
    }
}
