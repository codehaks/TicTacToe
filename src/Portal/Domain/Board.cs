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

        internal void Fork(PositionType positionType,MarkerType marker)
        {
            var pos=Positions.Single(p => p.Type == positionType);
            switch (marker)
            {
                case MarkerType.X:
                    pos.State = PositionState.X;
                    break;
                case MarkerType.O:
                    pos.State = PositionState.O;
                    break;
                default:
                    break;
            }
        }

        public IList<Position> Positions { get; private set; }
        
    }
}
