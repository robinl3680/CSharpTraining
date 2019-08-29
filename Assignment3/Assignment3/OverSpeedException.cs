using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class OverSpeedException : ApplicationException
    {
        private string message;
        public OverSpeedException(string message)
        {
            this.message = message;
        }
        public override string Message => this.message;
    }
}
