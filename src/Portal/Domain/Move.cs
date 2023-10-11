using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain;

public class Move
{
    public Move(Player player,PositionType positionType)
    {
        Player = player;
        PositionType = positionType;
    }
    public Player Player { get; }
    public PositionType PositionType { get;}
}


