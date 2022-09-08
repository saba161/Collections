using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GridFormatter<T>
    {
        public GridFormatter(IEnumerable<T> data)
        {
            //this.Data = data;
        }

        private IList<T> Data { get; }
    }
}
