using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tff.ConsoleUI.Models;

public sealed class Team : Entity<int>
{
    public string Name { get; set; }
    public DateTime Since { get; set; }

    public override string ToString()
    {
        return $"{Id}, {Name}, {Since}";
    }

}