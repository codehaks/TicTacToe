using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Domain
{
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
        
    }
}
