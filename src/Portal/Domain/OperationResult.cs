using System;

namespace Portal.Domain
{
    public class OperationResult
    {
        public bool Success { get; private set; }
        public ErrorType ErrorType { get; private set; }
        public string ErrorMessage { get; private set; }

        public static OperationResult BuildSuccess()
        {
            return new OperationResult { Success = true };
        }

        public static OperationResult BuildFailure(ErrorType errorType)
        {
            return new OperationResult { Success = false, ErrorType = errorType };
        }

        public static OperationResult BuildFailure(string errorMessage)
        {
            return new OperationResult { Success = false, ErrorMessage = errorMessage };
        }

        internal static OperationResult BuildFailure()
        {
            return new OperationResult { Success = false, ErrorType = ErrorType.Unknown };
        }
    }

    public enum ErrorType
    {
        Unknown = 0,

        PositionStateIsNotEmpty,

        BoardPositionAleadyForked
    }
}
