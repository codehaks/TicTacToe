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
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.One
                },

                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Two
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Three
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Four
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Five
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Six
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Seven
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Eight
                },
                new Position
                {
                    State = PositionState.Empty,
                    Type = PositionType.Nine
                },
            };
        }
        public IList<Position> Positions { get; private set; }
        public IList<Move> Moves { get; private set; }
        public void MovePlayer(Move move)
        {
            Moves.Add(move);
        }
    }
}
