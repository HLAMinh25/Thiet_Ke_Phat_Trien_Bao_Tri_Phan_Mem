using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: DUPLICATE OBSERVED DATA ===");

            // 1. Test Before
            Console.WriteLine("\n--- 1. Test Before ---");
            DuplicateObservedDataBefore before = new DuplicateObservedDataBefore();
            before.SimulateUserTyping("50");

            // 2. Test After
            Console.WriteLine("\n--- 2. Test After ---");
            var domainModel = new PesticideInventoryDomainModel();
            DuplicateObservedDataAfter after = new DuplicateObservedDataAfter(domainModel);
            after.SetInventoryQuantityFromUI(100);

            // 3. Test Real (Nghiệp vụ Form bán hàng nông dược An Giang)
            Console.WriteLine("\n--- 3. Test Real (Form Ban Hang Nong Duoc) ---");
            // Khởi tạo hóa đơn bán thuốc trừ sâu Benlate C với đơn giá 120,000 VND, ban đầu mua 5 sản phẩm
            var invoiceDomain = new InvoiceCalculationDomainModel(5, 120000);
            DuplicateObservedDataReal formReal = new DuplicateObservedDataReal(invoiceDomain);

            Console.WriteLine($"Trang thai Form ban dau -> SL: {formReal.UIQuantityInput} | Thanh tien hien thi: {formReal.UITotalAmountLabel}");

            // Giả lập nhân viên đại lý thay đổi số lượng mua lên 12 sản phẩm trên giao diện
            Console.WriteLine("\n[Hanh dong] Nhan vien thay doi so luong mua thanh 12...");
            formReal.UserChangedQuantityOnForm(12);

            Console.ReadKey();
        }
    }
}