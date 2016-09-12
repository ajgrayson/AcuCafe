using System;

namespace AcuCafe.Contracts
{
    public interface ILogger
    {
        void LogException(Exception ex);
    }
}
