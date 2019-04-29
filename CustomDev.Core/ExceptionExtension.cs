using System;
using System.Text;

namespace CustomDev
{
    public static class ExceptionExtension
    {
        /// <summary>
        /// Generate a full trace of an exception.
        /// A full trace contains:
        /// - the type of the exception
        /// - the message of the exception
        /// - the stack trace of the exception
        /// - the same information for inner exceptions
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string ToFullTrace(this Exception ex)
        {
            StringBuilder builder = new StringBuilder();
            Exception currentException = ex;

            builder.AppendLine("=== BEGIN EXCEPTION ===");

            while (ex != null)
            {
                builder.AppendLine(ex.GetType().ToString());
                builder.AppendLine(ex.Message);
                builder.AppendLine(ex.StackTrace);
                builder.AppendLine();
                ex = ex.InnerException;
            }

            builder.AppendLine("=== END EXCEPTION ===");

            return builder.ToString();
        }
    }
}
