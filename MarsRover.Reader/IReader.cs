using System;
using System.Collections.Generic;

namespace MarsRover.Reader
{
    public interface IReader<T>
    {
        IEnumerable<T> GetAll(string source);
    }
}
