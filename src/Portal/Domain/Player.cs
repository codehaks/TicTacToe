using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain;

public class Player
{
    public Player(string name,MarkerType marker)
    {
        Id = new Guid();
        Name = name;
        Marker = marker;
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public MarkerType Marker { get; }

}
