using System;
using System.Text;

namespace CustomDev
{
    public static class ExceptionExtension
    {
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
