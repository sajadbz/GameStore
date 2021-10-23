using GameStore.Data.Context;
using GameStore.Domain.Base;
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
    public class GameRepository : IGameRepository
    {
        private readonly GameStoreContext _context;
        public GameRepository()
        {
            _context = new GameStoreContext();
        }
        public void Add(Game entity)
        {
            entity.CreateDate = DateTime.Now;
            _context.Games.Add(entity);
            _context.SaveChanges();
        }

        public void AddRequirement(GameRequirement entity)
        {
            _context.GameRequirements.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(long id)
        {
            var game = Find(id);
            var req = FindRequirement(id);
            _context.GameRequirements.Remove(req);
            _context.Games.Remove(game);
            _context.SaveChanges();
        }

        public void Edit(Game entity)
        {
            _context.Games.Update(entity);
        }

        public void EditRequirement(GameRequirement requirement)
        {
            _context.GameRequirements.Update(requirement);
        }

        public Game Find(long id)
        {
            return _context.Games
                .Include(c => c.GameRequirement)
                .Include(c => c.Group)
                .SingleOrDefault(c => c.Id == id);
        }

        public GameRequirement FindRequirement(long gameId)
        {
            return _context.GameRequirements.Single(c => c.GameId == gameId);
        }

        public IQueryable<Game> GetAll()
        {
            return _context.Games
                .Include(c => c.GameRequirement)
                .Include(c => c.Group);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
