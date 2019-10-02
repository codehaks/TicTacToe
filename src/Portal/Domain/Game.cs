using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain
{
    public class Game
    {
        public Game(Player x,Player o)
        {
            Board = new Board();

            PlayerX = x;
            PlayerO = o;
        }
        public Board Board { get; private set; }
        public Player PlayerX { get; private set; }
        public Player PlayerO { get; private set; }

        public IList<Move> Moves { get; private set; }
        public void MovePlayer(Move move)
        {
            Moves.Add(move);
        }
    }
}
