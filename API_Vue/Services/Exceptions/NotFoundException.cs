using System;

namespace API_Vue.Services.Exceptions
{
    [Serializable]
    internal class NotFoundException : ApplicationException
    {
        public NotFoundException() 
        { 
        }
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
