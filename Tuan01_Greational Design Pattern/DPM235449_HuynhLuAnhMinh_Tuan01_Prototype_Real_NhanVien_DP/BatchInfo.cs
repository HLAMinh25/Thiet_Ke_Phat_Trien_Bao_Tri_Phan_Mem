using System;

namespace Bai4_Prototype
{
    public class BatchInfo
    {
        public string BatchCode { get; set; }
        public DateTime ExpiryDate { get; set; }

        public BatchInfo(string batchCode, DateTime expiryDate)
        {
            BatchCode = batchCode;
            ExpiryDate = expiryDate;
        }
    }
}