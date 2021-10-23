using GameStore.Core.Services.Interfaces;
using GameStore.Core.Values;
using GameStore.Core.ViewModels.Games;
using GameStore.Domain.Entities.Games;
using GameStore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStore.Core.Services.Implementations
{
    public class GameGroupService : IGameGroupService
    {
        private readonly IGameGroupRepository _gameGroupRepository;

        public GameGroupService(IGameGroupRepository gameGroupRepository)
        {
            _gameGroupRepository = gameGroupRepository;
        }

        public ResultType AddGroup(GameGroupVm vm)
        {
            try
            {
                _gameGroupRepository.Add(new GameGroup
                {
                    Title = vm.Title
                });
                return ResultType.Success;
            }
            catch (Exception ex)
            {
                return ResultType.Error;
            }
        }
        public ResultType EditGroup(GameGroupVm vm)
        {
            try
            {
                var model = _gameGroupRepository.Find(vm.Id);
                model.Title = vm.Title;
                _gameGroupRepository.Edit(model);
                return ResultType.Success;
            }
            catch (Exception ex)
            {
                return ResultType.Error;
            }
        }
        public ResultType DeleteGroup(int id)
        {
            try
            {
                _gameGroupRepository.Delete(id);
                return ResultType.Success;
            }
            catch (Exception ex)
            {
                return ResultType.Error;
            }
        }
        public GameGroupVm GetGroupById(int id)
        {
            var model = _gameGroupRepository.Find(id);
            return new GameGroupVm
            {
                Id = model.Id,
                Title = model.Title,
                GameCount = _gameGroupRepository.GameCountByGroupId(id)
            };
        }

        public List<GameGroupVm> GetGroups()
        {
            return _gameGroupRepository.GetAll()
                .Select(c => new GameGroupVm
                {
                    Id = c.Id,
                    Title = c.Title,
                    GameCount = c.Games.Count,
                }).ToList();
        }
        public List<GameGroupVm> SearchGroups(string title)
        {
            return _gameGroupRepository.GetAll()
                .Where(c => c.Title.ToLower().Contains(title))
                .Select(c => new GameGroupVm
                {
                    Id = c.Id,
                    Title = c.Title,
                    GameCount = c.Games.Count,
                }).ToList();
        }

        public List<GameGroupVm> FilterGroups(FilterGroup filter)
        {
            IQueryable<GameGroup> result = _gameGroupRepository.GetAll();

            if (!string.IsNullOrEmpty(filter.Title))
                result = result.Where(c => c.Title.ToLower().Contains(filter.Title));


            return result.Select(c => new GameGroupVm
            {
                Id = c.Id,
                Title = c.Title,
                GameCount = c.Games.Count,
            }).Skip((filter.Page - 1) * filter.PageSize)
            .Take(filter.PageSize)
            .ToList();
        }

        public int CountGroups()
        {
            return _gameGroupRepository.GetAll().Count();
        }
    }
}
