using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    // Lớp đại lý đóng vai trò là Value Object (mỗi hóa đơn tạo một bản sao khách hàng riêng biệt)
    public class CustomerValueObjectBefore
    {
        public string Name { get; set; }
        public CustomerValueObjectBefore(string name) { Name = name; }
    }

    public class ChangeValueToReferenceBefore
    {
        public string InvoiceId { get; set; }
        public CustomerValueObjectBefore Customer { get; set; }

        public ChangeValueToReferenceBefore(string invoiceId, string customerName)
        {
            InvoiceId = invoiceId;
            // Mỗi lần tạo hóa đơn là khởi tạo một đối tượng Customer mới độc lập
            Customer = new CustomerValueObjectBefore(customerName);
        }
    }
}   