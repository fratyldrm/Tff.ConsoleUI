using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tff.ConsoleUI.Models;

namespace Tff.ConsoleUI.Repsitory;

public class BaseRepository
{

    public static List<Team> Teams = new List<Team>()
    {
        new Team
        {
            Id = 1,
            Name = "GALATASARAY",
            Since = new DateTime(1905,10,1)
        },
        new Team
        {
            Id=2,
            Name = "FENERBAHÇE",
            Since = new DateTime(1907,5,3)
        },
        new Team
        {
            Id = 3,
            Name = "BEŞİKTAŞ JİMLASTİK KULÜBÜ",
            Since = new DateTime(1903,3,3)
        }
    };

    public static List<Player> Players = new List<Player>()
    {
        new Player
        {
            Id=new Guid("{D1ACC6AB-5D3A-43EB-AA39-9FEF0F1D1C56}"),
            Age = 25,
            Name = "Victor",
            Surname = "Osimhen",
            Number = "45",
            Branch = "Futbol",
            MarketValue = 100000000,
            TeamId = 1
        }
    };
}