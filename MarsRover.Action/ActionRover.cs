using MarsRover.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Action
{
    public abstract class ActionRover : IAction
    {
        protected ActionRover Successore; 

        public void SetSuccessor(ActionRover successore)
        {
            Successore = successore;
        }

        public abstract Rover GetAction(MappaMarte mappa, Rover r, char c); 
    }
}
