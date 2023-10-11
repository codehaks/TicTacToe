using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Domain;

public class Game
{
    public Game(Player playerX, Player playerO)
    {
        Board = new Board();
        Moves = new HashSet<Move>();

        PlayerX = playerX;
        PlayerO = playerO;

        Players = new List<Player>
        {
            PlayerX,
            PlayerO
        };

    }

    public Board Board { get; private set; }
    public List<Player> Players { get; }
    public Player PlayerX { get; }
    public Player PlayerO { get; }

    public GameResult GetWinner()
    {
        if (Moves.Count<5)
        {
            return GameResult.Play;
        }

        var xWins = Board.HasAllRow(PositionState.X);

        if (xWins)
        {
            return GameResult.XWins;
        }
        var oWins = Board.HasAllRow(PositionState.X);
        if (oWins)
        {
            return GameResult.OWins;
        }

        if (Moves.Count==9)
        {
            return GameResult.Draw;
        }
        else
        {
            return GameResult.Play;
        }
        
    }



    public HashSet<Move> Moves { get; private set; }

    public OperationResult AddMove(Move move)
    {
        if (Moves.Count >= 9)
        {
            OperationResult.BuildFailure(ErrorType.GameNoMoreMovesLeft);
        }
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
            if (PlayerX == lastPlayer)
            {
                return PlayerO;
            }
            else
            {
                return PlayerX;
            }
        }
        else
        {
            return PlayerX;
        }

    }
}

public enum GameResult
{
    Draw = 0,
    XWins = 1,
    OWins = 2,
    Play = 3
}
