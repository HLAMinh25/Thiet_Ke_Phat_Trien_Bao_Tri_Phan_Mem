using System;

namespace AnGiangPesticideRefactoring
{
    public class SupplierAfter
    {
        public string SupplierName { get; set; }
        public SupplierAfter(string name) { SupplierName = name; }
    }

    public class PesticideProductAfter
    {
        public string ProductName { get; set; }
        private SupplierAfter supplier;

        public PesticideProductAfter(string name, SupplierAfter supplier)
        {
            ProductName = name;
            this.supplier = supplier;
        }

        public SupplierAfter GetSupplier()
        {
            return supplier;
        }
    }

    public class HideDelegateAfter
    {
        public PesticideProductAfter Product { get; set; }

        public HideDelegateAfter(PesticideProductAfter product)
        {
            Product = product;
        }

        // Tạo phương thức ủy quyền trực tiếp, che giấu chi tiết bên trong (Hide Delegate)
        public SupplierAfter GetSupplier()
        {
            return Product.GetSupplier();
        }
    }
}