using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CA230116
{
    internal class NonPairException : Exception
    {
        public NonPairException(string? message) : base(message)
        {
        }
    }
}
