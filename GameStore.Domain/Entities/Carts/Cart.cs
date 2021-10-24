using GameStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities.Carts
{
    public class Cart : BaseEntity<long>
    {        
        public int UserId { get; set; }
        public bool IsFinalize { get; set; }        

    }
}
