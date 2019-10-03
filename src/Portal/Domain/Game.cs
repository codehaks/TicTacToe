﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Domain
{
    public class Game
    {
        public Game(Player player1, Player player2)
        {
            Board = new Board();
            Moves = new HashSet<Move>();

            Player1 = player1;
            Player2 = player2;
        }

        public Board Board { get; private set; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public HashSet<Move> Moves { get; private set; }

        public OperationResult MovePlayer(Move move)
        {

            var fork = Board.Fork(move.PositionType, move.Player.Marker);

            if (fork.Success)
            {
                var nextPlayer = GetNextTurn();
                if (nextPlayer == move.Player)
                {
                    var moveAdded = Moves.Add(move);

                    if (moveAdded)
                    {
                        return OperationResult.BuildSuccess();
                    }
                    else
                    {
                        return OperationResult.BuildFailure(ErrorType.MoveAlreadyExsited);
                    }
                }
                else
                {
                    return OperationResult.BuildFailure(ErrorType.GameNotPlayerTurn);
                }
            }
            else
            {
                return OperationResult.BuildFailure(ErrorType.BoardPositionAleadyForked);
            }
        }

        public Player GetNextTurn()
        {
            if (Moves.Any())
            {
                var lastPlayer = Moves.Last().Player;
                if (Player1 == lastPlayer)
                {
                    return Player2;
                }
                else
                {
                    return Player1;
                }
            }
            else
            {
                return null;
            }

        }
    }
}
