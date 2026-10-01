using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: CHANGE VALUE TO REFERENCE ===");

            // 1. Test Before
            var inv1Before = new ChangeValueToReferenceBefore("HD-01", "Dai ly Bay Long");
            var inv2Before = new ChangeValueToReferenceBefore("HD-02", "Dai ly Bay Long");
            // Hai hóa đơn này trỏ đến 2 đối tượng Customer khác nhau trong bộ nhớ (Value Objects)
            bool isSameCustomerBefore = object.ReferenceEquals(inv1Before.Customer, inv2Before.Customer);
            Console.WriteLine($"1. Ket qua Before (Cung chung 1 instance doi tuong khong?): {isSameCustomerBefore}");

            // 2. Test After
            var inv1After = new ChangeValueToReferenceAfter("HD-01", "Dai ly Bay Long");
            var inv2After = new ChangeValueToReferenceAfter("HD-02", "Dai ly Bay Long");
            // Hai hóa đơn này trỏ chung về MỘT thể hiện duy nhất trong bộ nhớ (Reference Objects)
            bool isSameCustomerAfter = object.ReferenceEquals(inv1After.Customer, inv2After.Customer);
            Console.WriteLine($"2. Ket qua After (Cung chung 1 instance doi tuong khong?): {isSameCustomerAfter}");

            // 3. Test Real (Nghiệp vụ quản lý danh mục sản phẩm thuốc bảo vệ thực vật An Giang)
            // Tạo 2 hóa đơn cho 2 đại lý khác nhau nhưng cùng mua một loại thuốc "Benlate C"
            ChangeValueToReferenceReal invoiceA = new ChangeValueToReferenceReal("HD-AG-101", "BVTV-001", "Thuoc Tru Sau Benlate C", 120000, 5);
            ChangeValueToReferenceReal invoiceB = new ChangeValueToReferenceReal("HD-AG-102", "BVTV-001", "Thuoc Tru Sau Benlate C", 120000, 10);

            Console.WriteLine("\n3. Ket qua Real:");
            invoiceA.PrintInvoiceItemInfo();
            invoiceB.PrintInvoiceItemInfo();

            // Kiểm chứng xem cả 2 hóa đơn có đang tham chiếu chính xác đến cùng một đối tượng sản phẩm trong kho hay không
            bool isSameProductShared = object.ReferenceEquals(invoiceA.Product, invoiceB.Product);
            Console.WriteLine($"-> Hai hoa don co tham chieu chung dung mot doi tuong san pham trong kho khong?: {isSameProductShared}");

            Console.ReadKey();
        }
    }
}