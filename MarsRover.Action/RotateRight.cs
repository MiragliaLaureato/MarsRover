using MarsRover.Model;

namespace MarsRover.Action
{
    public class RotateRight : ActionRover
    {
        public override Rover GetAction(MappaMarte mappa, Rover r, char c)
        {
            if (c.Equals('R'))
            {
                switch (r.Direction)
                {
                    case 'N':
                        r.Direction = 'E';
                        break;
                    case 'S':
                        r.Direction = 'O';
                        break;
                    case 'O':
                        r.Direction = 'N';
                        break;
                    case 'E':
                        r.Direction = 'S';
                        break;
                }
                return r;
            }
            else
            {
                return Successore.GetAction(mappa, r, c);
            }
        }

    }
}
