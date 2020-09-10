using System;

namespace ST.Utility.Exceptions
{
    public class BusinessException : Exception
    {
        public int ErrorCode { get; set; }

        public BusinessException(int errorCode, string errorMessage) 
            : base(errorMessage)
        {
            ErrorCode = errorCode;
        }

        public BusinessException(string Message) 
            : base(Message)
        {
            ErrorCode = (int)GeneralError.Failed;
        }
    }

    public class BusinessException<T> : BusinessException
    {
        public T Result { get; set; }

        public BusinessException(int errorCode, string errorMessage, T result) : base(errorCode, errorMessage)
        {
            Result = result;
        }
    }
}
