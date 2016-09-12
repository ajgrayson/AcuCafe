using System;
using AcuCafe.Contracts;

namespace AcuCafe
{
    public class Logger : ILogger
    {
        public void LogException(Exception ex)
        {
            // TODO: path to log should come from config
            System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
        }
    }
}
