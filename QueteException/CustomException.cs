using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueteException
{
    internal class CustomException : Exception
    {
        public DateTime Date { get; private set; }

        public CustomException(string message) : base(message)
        {
            Date = DateTime.Now;
        }
    }
}
