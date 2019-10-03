using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Portal.Test
{
    public class PositionShould
    {
        [Fact]
        public void SuccessOnChangingEmptyPositionState()
        {
            var position = new Position(PositionType.Five);
            var markOnEmpty = position.Mark(MarkerType.X);

            Assert.True(markOnEmpty.Success);
        }

        [Theory]
        [InlineData(PositionType.One, MarkerType.O)]
        [InlineData(PositionType.Two, MarkerType.X)]
        public void FailOnChangingStateOfNotEmptyPosition(PositionType positionType, MarkerType markerType)
        {
            var position = new Position(positionType);
            var markOnEmpty = position.Mark(markerType);
            var markOnX = position.Mark(markerType);

            Assert.True(markOnEmpty.Success && markOnX.Success == false);
        }

        [Fact]

        public void MarkXOtoPositionXO()
        {
            var p1 = new Position(PositionType.One);
            p1.Mark(MarkerType.X);

            var p2 = new Position(PositionType.Two);
            p2.Mark(MarkerType.O);

            Assert.True(p1.State == PositionState.X && p2.State == PositionState.O);
        }
    }
}
