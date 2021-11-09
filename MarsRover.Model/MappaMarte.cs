using System;

namespace MarsRover.Model
{
    public class MappaMarte
    {

        public bool[,] list_position;
        public MappaMarte(int dimension)
        {
            list_position = new bool[dimension, dimension];
        }
    }
}
