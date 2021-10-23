using GameStore.Domain.Base;
using GameStore.Domain.Entities.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Interfaces
{
    public interface IGameGroupRepository : IGenericRepository<int, GameGroup>
    {
        int GameCountByGroupId(int id);
    }
}
