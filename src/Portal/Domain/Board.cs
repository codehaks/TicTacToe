using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Domain;

public class Board
{
    public Board()
    {
        Positions = new List<Position>
        {
            new Position(PositionType.One),
            new Position(PositionType.Two),
            new Position(PositionType.Three),
            new Position(PositionType.Four),
            new Position(PositionType.Five),
            new Position(PositionType.Six),
            new Position(PositionType.Seven),
            new Position(PositionType.Eight),
            new Position(PositionType.Nine),
        };
    }

    internal OperationResult Fork(PositionType positionType,MarkerType marker)
    {
        var pos=Positions.Single(p => p.Type == positionType);
        var result=pos.Mark(marker);
        if (result.Success)
        {
            return OperationResult.BuildSuccess();
        }
        else if(result.ErrorType==ErrorType.PositionStateIsNotEmpty)
        {
            return OperationResult.BuildFailure(ErrorType.BoardPositionAleadyForked);
        }

        return OperationResult.BuildFailure();
    }

    public IList<Position> Positions { get; private set; }

    public bool HasAllRow(PositionState state)
    {
        //--- horizontal
        var r1 = Positions[0].State == state && Positions[1].State == state && Positions[2].State == state;
        var r2 = Positions[3].State == state && Positions[4].State == state && Positions[5].State == state;
        var r3 = Positions[6].State == state && Positions[7].State == state && Positions[8].State == state;

        //--- vertical
        var r4 = Positions[0].State == state && Positions[2].State == state && Positions[6].State == state;
        var r5 = Positions[1].State == state && Positions[4].State == state && Positions[7].State == state;
        var r6 = Positions[2].State == state && Positions[5].State == state && Positions[8].State == state;

        //--- Diagonal
        var r7 = Positions[0].State == state && Positions[4].State == state && Positions[8].State == state;
        var r8 = Positions[6].State == state && Positions[4].State == state && Positions[2].State == state;

        var result = r1 || r2 || r3 || r4 || r5 || r6 || r7 || r8;

        return result;
    }
    
}
