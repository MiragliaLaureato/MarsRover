using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Action
{
    public abstract class UpdatePositionRover
    {
        public static Rover Aggiorna(Rover rover, Posizione nuova)
        {
            rover.Position.X = nuova.X;
            rover.Position.Y = nuova.Y;
            return rover; 
        }
        
    }
}
