using System;

namespace Upgrade.Utils.Miscellaneous.Exceptions
{
    public class EmptyException : Exception
    {
        public EmptyException() : base(ExceptionMessages.EMPTY_EXCEPTION())
        {
        }
    }
}