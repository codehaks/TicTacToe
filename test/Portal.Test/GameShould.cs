using Portal.Domain;
using System;
using Xunit;

namespace Portal.Test
{
    public class GameShould
    {
        [Fact]
        public void FailOnConsecutiveMovesBySamePlayer()
        {
            var x = new Player("X", MarkerType.X);
            var o = new Player("O", MarkerType.O);

            var game = new Game(x, o);

            var move1=game.MovePlayer(new Move(x, PositionType.Five));
            var move2=game.MovePlayer(new Move(x, PositionType.Four));

            Assert.False(move2.Success);
        }

        [Fact]
        public void FailOnRepeatingSameMove()
        {
            var x = new Player("X", MarkerType.X);
            var o = new Player("O", MarkerType.O);

            var game = new Game(x, o);

            var move1 = game.MovePlayer(new Move(x, PositionType.Five));
            var move2 = game.MovePlayer(new Move(x, PositionType.Five));

            Assert.False(move2.Success);
            //Assert.True(move2.ErrorType == ErrorType.MoveAlreadyExsited);
        }

        [Fact]
        public void FailOnNotKeepingTurn()
        {
            var x = new Player("X", MarkerType.X);
            var o = new Player("O", MarkerType.O);

            var game = new Game(x, o);

            var move1 = game.MovePlayer(new Move(x, PositionType.Five));
            var move2 = game.MovePlayer(new Move(x, PositionType.Six));

            Assert.False(move2.Success);
            Assert.True(move2.ErrorType == ErrorType.GameNotPlayerTurn);
        }

        [Fact]
        public void FailOnForkingNotEmptyPosition()
        {
            var x = new Player("X", MarkerType.X);
            var o = new Player("O", MarkerType.O);

            var game = new Game(x, o);

            var move1 = game.MovePlayer(new Move(x, PositionType.Five));
            var move2 = game.MovePlayer(new Move(o, PositionType.Five));

            Assert.False(move2.Success);
        }

        [Fact]
        public void StartWithPlayerXTurn()
        {
            var x = new Player("X", MarkerType.X);
            var o = new Player("O", MarkerType.O);

            var game = new Game(x, o);

            var firstPlayer = game.GetNextTurn();
            Assert.Equal(x, firstPlayer);
        }
    }
}
