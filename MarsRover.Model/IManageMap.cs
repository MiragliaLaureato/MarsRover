using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public interface IManageMap<T>
    {
        void CreateMap(int dimension);

        void AddObstacles(int dimension);

        void AddRover(Rover r);
    }
}
