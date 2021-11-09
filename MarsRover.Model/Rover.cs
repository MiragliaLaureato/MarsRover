namespace MarsRover.Model
{
    public class Rover : IRobot
    {
        public Posizione Position { get; set; }
        public char Direction { get; set; }

        public Rover(Posizione pos, char dir)
        {
            Position = pos;
            Direction = dir; 
        }
    }
}
