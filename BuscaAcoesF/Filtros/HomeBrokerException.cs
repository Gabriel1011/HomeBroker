using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace HomeBroker.Filtros
{
    public class HomeBrokerException : Exception
    {
        public HomeBrokerException()
        {
            MessageBox.Show("Errp");
        }

        public HomeBrokerException(string message) : base(message)
        {
        }

        public HomeBrokerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HomeBrokerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
