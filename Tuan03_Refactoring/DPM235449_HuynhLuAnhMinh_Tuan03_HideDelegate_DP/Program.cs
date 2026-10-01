using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: HIDE DELEGATE ===");

            // 1. Test Before
            var supplierBefore = new SupplierBefore("Cong ty Hoa chat Nong duoc Mien Nam");
            var productBefore = new PesticideProductBefore("Thuoc Tru Sau Anvil", supplierBefore);
            HideDelegateBefore hideBefore = new HideDelegateBefore(productBefore);
            // Client phải gọi chuỗi dài: hideBefore.Product.GetSupplier().SupplierName
            Console.WriteLine($"1. Ket qua Before (Nha cung cap): {hideBefore.Product.GetSupplier().SupplierName}");

            // 2. Test After
            var supplierAfter = new SupplierAfter("Cong ty Hoa chat Nong duoc Mien Nam");
            var productAfter = new PesticideProductAfter("Thuoc Tru Sau Anvil", supplierAfter);
            HideDelegateAfter hideAfter = new HideDelegateAfter(productAfter);
            // Client gọi trực tiếp qua phương thức ủy quyền: hideAfter.GetSupplier()
            Console.WriteLine($"2. Ket qua After (Nha cung cap): {hideAfter.GetSupplier().SupplierName}");

            // 3. Test Real (Nghiệp vụ chứng nhận kiểm định lô nông dược An Giang)
            var qcCert = new QualityControlCertificate("QC-AG-2026-88", DateTime.Now.AddDays(-10), "Ky su Tran Van Thanh");
            var batchRecord = new PesticideBatchRecord("LO-BVTV-BENLATE-01", qcCert);
            HideDelegateReal hideReal = new HideDelegateReal("HD-AG-999", batchRecord);
            Console.WriteLine("3. Ket qua Real:");
            hideReal.PrintInvoiceWithQC();

            Console.ReadKey();
        }
    }
}