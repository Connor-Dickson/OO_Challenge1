using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge01
{
    public class LengthException : Exception
    {
        public LengthException() : base("Length entered was less than one")
        {

        }
    }
}
