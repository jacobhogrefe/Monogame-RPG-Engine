using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;
using Autofac.Core.Lifetime;

namespace Engine.Utils
{
    public enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN,
        NONE,
    }

    // extensions to call functions based on this enum
    public static class DirectionExtensions
    {
        public static Direction Inverse(this Direction direction)
        {
            return direction switch
            {
                Direction.LEFT => Direction.RIGHT,
                Direction.RIGHT => Direction.LEFT,
                Direction.UP => Direction.DOWN,
                Direction.DOWN => Direction.UP,
                _ => Direction.NONE,
            };
        }

        public static bool ParallelToXAxis(this Direction direction)
        {
            return direction == Direction.UP || direction == Direction.DOWN;
        }

        public static bool ParallelToYAxis(this Direction direction)
        {
            return direction == Direction.LEFT || direction == Direction.RIGHT;
        }
    }
}
