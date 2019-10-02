using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain
{
    public class Board
    {
        public Board()
        {
            Positions = new List<Position>
            {
                new Position(PositionType.One,PositionState.Empty),
                new Position(PositionType.Two,PositionState.Empty),
                new Position(PositionType.Three,PositionState.Empty),
                new Position(PositionType.Four,PositionState.Empty),
                new Position(PositionType.Five,PositionState.Empty),
                new Position(PositionType.Six,PositionState.Empty),
                new Position(PositionType.Seven,PositionState.Empty),
                new Position(PositionType.Eight,PositionState.Empty),
                new Position(PositionType.Nine,PositionState.Empty),
            };
        }
        public IList<Position> Positions { get; private set; }
        
    }
}
