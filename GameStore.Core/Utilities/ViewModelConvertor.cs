using GameStore.Core.Values;
using GameStore.Core.ViewModels.Games;
using GameStore.Domain.Entities.Games;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Core.Utilities
{
    public static class ViewModelConvertor
    {
        public static GameVm ToViewModel(this Game game)
        {

            return new GameVm
            {
                Id = game.Id,
                GroupId = game.GroupId,
                Name = game.Name,
                GroupName = game.Group.Title,
                Price = game.Price,
                Year = game.Year,
                Platform = game.Platform,
                CPU = game.GameRequirement.CPU,
                FreeSpace = game.GameRequirement.FreeSpace,
                GPU = game.GameRequirement.GPU,
                RAM = game.GameRequirement.RAM,
                Note = game.GameRequirement.Note,
                Image = !string.IsNullOrEmpty(game.ImageName)
                ? Image.FromFile(Path.Combine(Paths.GameImagePath, game.ImageName))
                : Image.FromFile(Paths.DefaultImage)
            };
        }
        public static IQueryable<GameVm> ToViewModel(this IQueryable<Game> games)
        {
            return games.Select(c => c.ToViewModel());
        }
    }
}
