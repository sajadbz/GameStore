using GameStore.Data.Context;
using GameStore.Domain.Entities.Games;
using GameStore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Data.Repositories
{
    public class GameGroupRepository : IGameGroupRepository
    {
        private readonly GameStoreContext _context;
        public GameGroupRepository()
        {
            _context = new GameStoreContext();
        }
        public void Add(GameGroup entity)
        {
            entity.CreateDate = DateTime.Now;
            _context.GameGroups.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var model = _context.GameGroups.Find(id);
            _context.GameGroups.Remove(model);
            _context.SaveChanges();
        }

        public void Edit(GameGroup entity)
        {
            _context.GameGroups.Update(entity);
            _context.SaveChanges();
        }

        public GameGroup Find(int id)
        {
            return _context.GameGroups
                .Include(c => c.Games)
                //.ThenInclude(c => c.GameRequirement)
                .SingleOrDefault(c => c.Id == id);
        }

        public int GameCountByGroupId(int id)
        {
            return _context.Games.Count(c => c.GroupId == id);
        }

        public IQueryable<GameGroup> GetAll()
        {
            return _context.GameGroups.Include(c => c.Games);
        }
    }
}
