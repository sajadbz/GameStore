using GameStore.Domain.Base;
using GameStore.Domain.Entities.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Interfaces
{
    public interface IGameRepository :
        IGenericRepository<long, Game>        
    {
        GameRequirement FindRequirement(long gameId);
        void AddRequirement(GameRequirement requirement);
        void EditRequirement(GameRequirement requirement);
        int Save();
    }
}
