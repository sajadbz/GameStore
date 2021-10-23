using GameStore.Core.Services.Implementations;
using GameStore.Core.Services.Interfaces;
using GameStore.Core.ViewModels.Games;
using GameStore.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameStore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            IoC.Container container = new IoC.Container();
            var ServiceProvider = container.Register();

            //IGameGroupService gameGroupService = new GameGroupService(new GameGroupRepository());
            //GameGroupRepository gameGroupRepository = new GameGroupRepository();
            IGameGroupService gameGroupService = ServiceProvider.GetService<IGameGroupService>();
            Console.WriteLine("Hello Class!");

            #region Add
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Enter Game Group Title : ");
            //    var title = Console.ReadLine();
            //    gameGroupRepository.Add(new GameGroup()
            //    {
            //        CreateDate = DateTime.Now,
            //        Title = title
            //    });
            //    Console.WriteLine($"'{title}' added :)");
            //}
            #endregion

            #region Get All
            foreach (var item in gameGroupService.GetGroups())
            {
                Console.WriteLine($"{item.Id}, {item.Title}, {item.GameCount}");
            }

            #endregion

            #region Remove
            //Console.Write("Enter number of game group for remove :");
            //int groupId = int.Parse(Console.ReadLine());
            //gameGroupRepository.Delete(groupId);
            #endregion

            Console.WriteLine("Done !!!");
        }
    }
}
