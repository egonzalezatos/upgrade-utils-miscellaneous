using System;

namespace Upgrade.Utils.Miscellaneous.Exceptions
{
    public class NullException : Exception
    {
        public NullException() : base(ExceptionMessages.NULL_EXCEPTION())
        {
        }

    }
}