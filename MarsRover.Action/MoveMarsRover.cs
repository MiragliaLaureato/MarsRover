using MarsRover.Model;
using System;

namespace MarsRover.Action
{
    public class MoveMarsRover : ActionRover
    {
        public override Rover GetAction(MappaMarte mappa, Rover r, char c)
        {
            var vecchiaposizione = r.Position;
            
            if (c.Equals('F') || c.Equals('B'))
            {
                var nuovaposizione = NextPosition.NextOne(mappa, r, c); 
                if (CheckMovementInMars.CheckMovement(mappa, nuovaposizione)) 
                {
                    r = UpdatePositionRover.Aggiorna(r, nuovaposizione);
                } 
            }
            return r; 
        }
    }
}
