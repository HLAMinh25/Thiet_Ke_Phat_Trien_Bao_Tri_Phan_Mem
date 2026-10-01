using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    // Lớp đại lý được chuyển thành Reference Object
    public class CustomerReferenceAfter
    {
        public string Name { get; }
        private static readonly Dictionary<string, CustomerReferenceAfter> instances = new Dictionary<string, CustomerReferenceAfter>();

        private CustomerReferenceAfter(string name) { Name = name; }

        // Factory Method quản lý instance duy nhất cho mỗi tên đại lý (Reference)
        public static CustomerReferenceAfter GetInstance(string name)
        {
            if (!instances.ContainsKey(name))
            {
                instances[name] = new CustomerReferenceAfter(name);
            }
            return instances[name];
        }
    }

    public class ChangeValueToReferenceAfter
    {
        public string InvoiceId { get; set; }
        public CustomerReferenceAfter Customer { get; set; }

        public ChangeValueToReferenceAfter(string invoiceId, string customerName)
        {
            InvoiceId = invoiceId;
            // Sử dụng chung một Reference Object thông qua Factory
            Customer = CustomerReferenceAfter.GetInstance(customerName);
        }
    }
}