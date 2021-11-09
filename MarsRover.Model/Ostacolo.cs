using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Ostacolo
    {
        public Posizione Position { get; set; }

        public Ostacolo(Posizione posizione)
        {
            Position = posizione; 
        }
    }
}
