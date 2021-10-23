using GameStore.Core.Values;
using GameStore.Core.ViewModels.Games;
using System.Collections.Generic;

namespace GameStore.Core.Services.Interfaces
{
    public interface IGameService
    {
        GameVm GetGameById(int id);
        ResultType AddGame(GameVm vm);
        List<GameVm> GetGames();
        List<GameVm> GetGames(int groupId);
    }
}
