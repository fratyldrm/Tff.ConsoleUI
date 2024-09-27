using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff.ConsoleUI.Models;

namespace Tff.ConsoleUI.Repsitory
{
    public class PlayerRepository : IRepository<Player, Guid>
    {
        public Player Add(Player entity)
        {
            BaseRepository.Players.Add(entity);
            return entity;
        }

        public Player? Delete(Guid id)
        {
            Player? player = GetById(id);
            if (player == null)
            {
                // Exception Fırlat
                return null;
            }
            BaseRepository.Players.Remove(player);
            return player;
        }

        public List<Player> GetAll()
        {
            return BaseRepository.Players;
        }

        public Player? GetById(Guid id)
        {
            return BaseRepository.Players.SingleOrDefault(p => p.Id == id);
        }

        public Player? Update(Guid id, Player entity)
        {
            Player? player = GetById(id);
            if (player == null)
            {
                return null;
            }

            int index = BaseRepository.Players.IndexOf(player);

            Player updatedPlayer = new()
            {
                Id = entity.Id,
                Name = entity.Name,
                Age = entity.Age,
                Branch = entity.Branch,
                MarketValue = entity.MarketValue,
                Number = entity.Number,
                Surname = entity.Surname,
                TeamId = entity.TeamId,

            };

            BaseRepository.Players.Remove(player);
            BaseRepository.Players.Insert(index, updatedPlayer);

            return updatedPlayer;
        }
    }
}