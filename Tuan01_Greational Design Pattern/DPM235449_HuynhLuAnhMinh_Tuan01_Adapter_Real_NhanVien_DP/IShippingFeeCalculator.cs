using System;

namespace NongDuocAnGiang.DesignPatterns.Adapter
{
    public interface IShippingFeeCalculator
    {
        decimal CalculateShipping(string invoiceId, double distanceInKm);
    }
}