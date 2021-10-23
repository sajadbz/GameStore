using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities.Carts
{
    public class CartDetails
    {
        public int CartId { get; set; }
        public int GameId { get; set; }
        public int Price { get; set; }
    }
}
