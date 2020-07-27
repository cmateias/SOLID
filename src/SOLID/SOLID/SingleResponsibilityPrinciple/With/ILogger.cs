using System;

namespace SOLID.SingleResponsibilityPrinciple.With
{
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
}