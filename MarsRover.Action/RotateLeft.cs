using MarsRover.Model;

namespace MarsRover.Action
{
    public class RotateLeft : ActionRover
    {
        public override Rover GetAction(MappaMarte mappa, Rover r, char c)
        {
            if (c.Equals('L'))
            {
                switch (r.Direction)
                {
                    case 'N':
                        r.Direction = 'O';
                        break;
                    case 'S':
                        r.Direction = 'E';
                        break;
                    case 'O':
                        r.Direction = 'S';
                        break;
                    case 'E':
                        r.Direction = 'N';
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
