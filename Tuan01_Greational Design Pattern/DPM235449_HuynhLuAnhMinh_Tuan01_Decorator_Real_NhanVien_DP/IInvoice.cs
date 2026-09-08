using System;

namespace NongDuocAnGiang.DesignPatterns.Decorator
{
    public interface IInvoice
    {
        string GetDescription();
        decimal CalculateTotal();
    }
}