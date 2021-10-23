using GameStore.Core.Values;
using GameStore.Core.ViewModels.Games;
using GameStore.Domain.Entities.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Services.Interfaces
{
    public interface IGameGroupService
    {
        GameGroupVm GetGroupById(int id);
        ResultType AddGroup(GameGroupVm vm);
        List<GameGroupVm> GetGroups();
        List<GameGroupVm> SearchGroups(string title);
        List<GameGroupVm> FilterGroups(FilterGroup filter);
        ResultType EditGroup(GameGroupVm gameGroupVm);
        ResultType DeleteGroup(int id);
        int CountGroups();
    }
}
