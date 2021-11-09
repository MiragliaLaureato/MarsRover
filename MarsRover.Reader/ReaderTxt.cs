using MarsRover.Action;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Reader
{
    public class ReaderCharAction : IReader<char>
    {
        public IEnumerable<char> GetAll(string source) => File.ReadAllText(source).ToCharArray();
    }
}
