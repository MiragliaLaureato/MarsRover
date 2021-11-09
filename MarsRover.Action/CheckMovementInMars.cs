using MarsRover.Model;
using System;

namespace MarsRover.Action
{
    public static class CheckMovementInMars
    {
        public static bool CheckMovement(MappaMarte m, Posizione p) => m.list_position[p.X, p.X]; 
    }
}
