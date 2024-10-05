using System.Threading;

namespace BSS.Logging
{
    internal class Program
    {
        static void Main()
        {
            Log.Initialize();

            Log.FastLog("Info message from ThreadPool", LogSeverity.Info, "ThreadPool");
            Log.FastLog("Warning  message from database thread", LogSeverity.Warning, "DB Thread");
            Log.FastLog("Alert message from enclave handler", LogSeverity.Alert, "Security Thing");
            Log.FastLog("Verbose message from Login", LogSeverity.Verbose, "Login");
            Log.FastLog("Debug message from Init() at line 323", LogSeverity.Debug, "Init()");
            Log.FastLog("Error message from ThreadPool", LogSeverity.Error, "ThreadPool");
            Log.FastLog("Critical message from LoginValidator", LogSeverity.Critical, "LoginValidator");

            xDebug.WriteLine("\ndirect console write");

            Thread.Sleep(-1);
        }
    }
}