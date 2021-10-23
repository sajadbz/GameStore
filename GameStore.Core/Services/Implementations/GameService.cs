using GameStore.Core.Services.Interfaces;
using GameStore.Core.Utilities;
using GameStore.Core.Values;
using GameStore.Core.ViewModels.Games;
using GameStore.Domain.Entities.Games;
using GameStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Services.Implementations
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGameGroupRepository gameGroupRepository;
        public GameService(IGameRepository gameRepository, IGameGroupRepository gameGroupRepository)
        {
            _gameRepository = gameRepository;
            this.gameGroupRepository = gameGroupRepository;
        }
        public ResultType AddGame(GameVm vm)
        {
            try
            {
                string fileName = null;
                if (!string.IsNullOrEmpty(vm.ImageName))
                {
                    fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(vm.ImageName);
                    File.Copy(vm.ImageName, Path.Combine(Paths.GameImagePath, fileName));
                }
                var game = new Game()
                {
                    GroupId = vm.GroupId,
                    Name = vm.Name,
                    Platform = vm.Platform,
                    Price = vm.Price,
                    Year = vm.Year,
                    ImageName = fileName
                };

                _gameRepository.Add(game);
                _gameRepository.AddRequirement(new GameRequirement
                {
                    GameId = game.Id,
                    CPU = vm.CPU,
                    FreeSpace = vm.FreeSpace,
                    GPU = vm.GPU,
                    Note = vm.Note,
                    RAM = vm.RAM
                });
                return ResultType.Success;
            }
            catch (Exception ex)
            {

                return ResultType.Error;
            }
        }

        public GameVm GetGameById(int id)
        {
            return _gameRepository.Find(id).ToViewModel();
            //var req = _gameRepository.FindRequirement(id);
            //var group = gameGroupRepository.Find(game.GroupId);
            //return new GameVm
            //{
            //    GroupId = group.Id,
            //    GroupName = group.Title,
            //    Id = game.Id,
            //    Name = game.Name,
            //    Price = game.Price,
            //    Platform = game.Platform,
            //    Year = game.Year,
            //    CPU = req.CPU,
            //    RAM = req.RAM,
            //    FreeSpace = req.FreeSpace,
            //    GPU = req.GPU,
            //    Note = req.Note,
            //};
        }

        public List<GameVm> GetGames()
        {
            return _gameRepository.GetAll()
                .ToViewModel()
                .ToList();
        }

        public List<GameVm> GetGames(int groupId)
        {
            return _gameRepository.GetAll()
                .Where(c => c.GroupId == groupId)
                .ToViewModel()
                .ToList();
        }
    }
}
