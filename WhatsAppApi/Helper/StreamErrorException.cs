using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatsAppApi.Helper
{
    public class StreamErrorException : Exception
    {
        public StreamErrorException()
            : base()
        {

        }
        public StreamErrorException(string message)
            : base(message)
        {

        }
        public StreamErrorException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
