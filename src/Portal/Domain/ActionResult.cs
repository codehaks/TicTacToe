using System;

namespace Portal.Domain
{
    public class ActionResult
    {
        public bool Success { get; private set; }
        public ErrorType ErrorType { get; private set; }
        public string ErrorMessage { get; private set; }

        public static ActionResult BuildSuccess()
        {
            return new ActionResult { Success = true };
        }

        public static ActionResult BuildFailure(ErrorType errorType)
        {
            return new ActionResult { Success = false, ErrorType = errorType };
        }

        public static ActionResult BuildFailure(string errorMessage)
        {
            return new ActionResult { Success = false, ErrorMessage = errorMessage };
        }

        internal static ActionResult BuildFailure()
        {
            return new ActionResult { Success = false, ErrorType = ErrorType.Unknown };
        }
    }

    public enum ErrorType
    {
        Unknown = 0,

        PositionStateIsNotEmpty,

        BoardPositionAleadyForked
    }
}
