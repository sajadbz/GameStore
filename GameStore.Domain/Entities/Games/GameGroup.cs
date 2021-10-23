using GameStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities.Games
{
    public class GameGroup : BaseEntity<int>
    {
        public GameGroup()
        {
            Games = new List<Game>();
        }
        public string Title { get; set; }

        #region Relations
        public ICollection<Game> Games { get; set; }
        #endregion
    }
}
