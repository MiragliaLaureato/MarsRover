using System;
using System.Collections.Generic;


namespace MarsRover.Model
{
    public class ManageMars : IManageMap<MappaMarte>
    {
        public MappaMarte MapMars;
        public void CreateMap(int dimension)
        {
            MapMars = new MappaMarte(dimension);
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    MapMars.list_position.SetValue(true, i, j);
                }
            }
            AddObstacles(dimension);
        }

        public void AddObstacles(int dimension)
        {
            var numOstacoli = Convert.ToInt32(Math.Sqrt(dimension));
            var random = new Random();
            for (int i = 0; i < numOstacoli; i++)
            {
                var x = random.Next(0, dimension - 1);
                var y = random.Next(0, dimension - 1);

                MapMars.list_position.SetValue(false, x, y);
            }
        }

        public void AddRover(Rover r)
        {
            if (CheckFreePosition(r.Position))
            {
                MapMars.list_position.SetValue(false, r.Position.X, r.Position.Y);
            }
            
        }
        
        public bool CheckFreePosition(Posizione p) => MapMars.list_position[p.X, p.Y]; 
        
    }
}
