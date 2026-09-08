using System;

namespace NongDuocAnGiang.DesignPatterns.Proxy
{
    public interface IReportService
    {
        void GenerateDiscountReport(string targetEmployeeId);
    }
}