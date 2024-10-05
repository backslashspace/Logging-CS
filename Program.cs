using System.Threading;

namespace BSS.Logging
{
    internal class Program
    {
        static void Main()
        {
            Log.Initialize();

            Log.FastLog("Test message", LogSeverity.Info, "Tddddest");
            Log.FastLog("Test message", LogSeverity.Warning, "Teddst");
            Log.FastLog("Test message", LogSeverity.Alert, "Teffffffffffffst");
            Log.FastLog("Test message", LogSeverity.Verbose, "Tefffffst");
            Log.FastLog("Test message", LogSeverity.Debug, "Tefffst");
            Log.FastLog("Test message", LogSeverity.Error, "Teffst");
            Log.FastLog("Test message", LogSeverity.Critical, "Tfest");

            Thread.Sleep(-1);
        }
    }
}