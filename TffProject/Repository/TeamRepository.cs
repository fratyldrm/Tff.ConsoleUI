using System.Numerics;
using Tff.ConsoleUI.Models;

namespace Tff.ConsoleUI.Repsitory;

// ClassAdı.MetodAdı();
public class TeamRepository : IRepository<Team, int>
{

  
    public Team Add(Team entity)
    {
        BaseRepository.Teams.Add(entity);
        return entity;
    }

    public Team? Delete(int id)
    {
        Team? team = GetById(id);
        if(team == null)
        {
            //Exeption Firlat


            throw new Exception($"{id}Aradiginiz id e gore takim bulunmadi");
        }
        BaseRepository.Teams.Remove(team);
        return team;
    }

    public List<Team> GetAll()
    {
      return BaseRepository.Teams.ToList();
    }

    public Team? GetById(int id)
    {
        return BaseRepository.Teams.SingleOrDefault(p => p.Id == id);
    }

    public Team? Update(int id, Team entity)
    {

        Team? team = GetById(id);
        if (team == null)
        {
            return null;
        }

        int index = BaseRepository.Teams.IndexOf(team);

        Team updatedTeam = new()
        {
            Id = entity.Id,
            Name = entity.Name,
            Since = entity.Since,
        };
        BaseRepository.Teams.Remove(team);
        BaseRepository.Teams.Insert(index, updatedTeam);

        return team;
    }
    
}