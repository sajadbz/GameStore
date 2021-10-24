using GameStore.Domain.Entities.Carts;
using GameStore.Domain.Entities.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace GameStore.Data.Context
{
    public class GameStoreContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<GameRequirement> GameRequirements { get; set; }
        public DbSet<GameGroup> GameGroups { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // User ID={username}; Password={password};
            optionsBuilder
                .UseSqlServer(@"Server=.;Database=dbGameStore;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var date = new DateTime(2021, 10, 10, 19, 28, 00);
            modelBuilder.Entity<GameGroup>()
                .HasData(new List<GameGroup>
                {
                    new GameGroup{Id =1,Title = "Action",CreateDate= date},
                    new GameGroup{Id =2,Title = "Adventure",CreateDate= date},
                    new GameGroup{Id =3,Title = "Racing",CreateDate= date},

                });            
            base.OnModelCreating(modelBuilder);
        }
    }
}
