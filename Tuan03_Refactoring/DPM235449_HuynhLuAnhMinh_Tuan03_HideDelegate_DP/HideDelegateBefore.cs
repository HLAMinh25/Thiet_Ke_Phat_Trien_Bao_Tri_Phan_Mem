using System;

namespace AnGiangPesticideRefactoring
{
    public class SupplierBefore
    {
        public string SupplierName { get; set; }
        public SupplierBefore(string name) { SupplierName = name; }
    }

    public class PesticideProductBefore
    {
        public string ProductName { get; set; }
        private SupplierBefore supplier;

        public PesticideProductBefore(string name, SupplierBefore supplier)
        {
            ProductName = name;
            this.supplier = supplier;
        }

        // Lớp Product cung cấp hàm trả về Supplier
        public SupplierBefore GetSupplier()
        {
            return supplier;
        }
    }

    public class HideDelegateBefore
    {
        public PesticideProductBefore Product { get; set; }

        public HideDelegateBefore(PesticideProductBefore product)
        {
            Product = product;
        }
    }
}