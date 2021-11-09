using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Action
{
    public class UpdateMarsMaps
    {
        public static MappaMarte UpdateMappa(MappaMarte mappa, Posizione partenza, Posizione arrivo)
        {
            mappa.list_position[partenza.X, partenza.Y] = true;
            mappa.list_position[arrivo.X, arrivo.Y] = false ;
            return mappa; 
        }
    }
}
