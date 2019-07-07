using System;

namespace EtherCommerce.Common.Exceptions
{
    public class EtherCommerceException : Exception
    {
        public string Code { get; }


        public EtherCommerceException()
        {
        }

        public EtherCommerceException(string code)
        {
            Code = code;
        }

        public EtherCommerceException(string message, params object[] args)
            : this(string.Empty, message, args)
        {
        }

        public EtherCommerceException(string code, string message, params object[] args)
            : this(null, code, message, args)
        {
        }

        public EtherCommerceException(Exception innerException, string message, params object[] args)
            : this(innerException, string.Empty, message, args)
        {
        }

        public EtherCommerceException(Exception innerException, string code, string message, params object[] args)
            : base(string.Format(message, args), innerException)
        {
            Code = code;
        }
    }
}
