﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain
{
    public class Position
    {
        public Position(PositionType type)
        {
            Type = type;
            State = PositionState.Empty;
        }
        public PositionType Type { get; private set; }
        public PositionState State { get; set; }
    }

    public enum PositionType
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9
    }

    public enum PositionState
    {
        Empty = 0,
        X = 1,
        O = 2
    }
}
