using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.ConsoleUI.Models;

public sealed class Player : Entity<Guid>
{

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Number { get; set; }
    public string Branch { get; set; }
    public int Age { get; set; }
    public double MarketValue { get; set; }

    public int TeamId { get; set; }


    public override string ToString()
    {
        return $"{Id},{Name}, {Surname}, {Number}, {Branch},{Age},{MarketValue},{TeamId}";
    }

}