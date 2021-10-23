using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities.Carts
{
    public class Cart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public bool IsFinalize { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
