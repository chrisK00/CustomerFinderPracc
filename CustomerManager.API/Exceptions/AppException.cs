using System;

namespace CustomerManager.API.Exceptions
{
    public class AppException : Exception
    {
        public AppException() 
        {
        }

        public AppException(string message) : base(message)
        {
        }
    }
}