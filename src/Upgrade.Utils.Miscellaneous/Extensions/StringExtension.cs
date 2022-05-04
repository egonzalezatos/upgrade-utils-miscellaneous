using Upgrade.Utils.Miscellaneous.Exceptions;

namespace Upgrade.Utils.Miscellaneous.Extensions
{
    public static class StringExtension
    {
        public static void ThrowIfNullOrEmpty(this string s)
        {
            if (s == null) throw new NullException();
            if (string.IsNullOrEmpty(s)) 
                throw new EmptyException();
        }
    }
}