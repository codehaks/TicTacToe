using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Domain
{
    public class Game
    {
        public Game(Player player1,Player player2)
        {
            Board = new Board();

            Player1 = player1;
            Player2 = player2;
        }

        public Board Board { get; private set; }
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        public IList<Move> Moves { get; private set; }

        public ActionResult MovePlayer(Move move)
        {
            var position = Board.Positions.Single(p => p.Type == move.PositionType);
            if (position.State==PositionState.Empty)
            {
                Board.Fork(move.PositionType, move.Player.Marker);
                Moves.Add(move);
                

                return ActionResult.BuildSuccess();
            }
            else
            {
                return ActionResult.BuildFailure("Position already forked");
            }
            
        }
    }
}
