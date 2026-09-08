using System;

namespace NongDuocAnGiang.DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ KHO CÔNG TY NÔNG DƯỢC ===");
            Console.WriteLine("Chức năng: Quản lý hàng hóa theo Lô và Thùng\n");

            // 1. Tạo các sản phẩm đơn lẻ (Leaf)
            InventoryComponent thuocTruSau1 = new Product("Thuốc trừ sâu sinh học A1", 150000m);
            InventoryComponent thuocTruSau2 = new Product("Thuốc trừ sâu sinh học A1", 150000m);
            InventoryComponent phanBon1 = new Product("Phân bón NPK Cao cấp", 350000m);
            InventoryComponent phanBon2 = new Product("Phân bón NPK Cao cấp", 350000m);

            // 2. Nhóm các sản phẩm vào các Thùng hàng nhỏ (Composite)
            InventoryComponent thungThuocTruSau = new ProductBatch("Thùng Thuốc Trừ Sâu (2 chai)");
            thungThuocTruSau.Add(thuocTruSau1);
            thungThuocTruSau.Add(thuocTruSau2);

            InventoryComponent thungPhanBon = new ProductBatch("Bao lớn Phân Bón (2 bao nhỏ)");
            thungPhanBon.Add(phanBon1);
            thungPhanBon.Add(phanBon2);

            // 3. Đóng gói tất cả vào một Lô hàng xuất kho (Composite cấp cao nhất)
            InventoryComponent loHangXuatKho = new ProductBatch("LÔ HÀNG XUẤT KHO NGÀY 08/09");
            loHangXuatKho.Add(thungThuocTruSau);
            loHangXuatKho.Add(thungPhanBon);

            // Thêm một sản phẩm lẻ bán kèm trực tiếp vào Lô mà không cần đóng thùng
            InventoryComponent thuocDietCo = new Product("Thuốc diệt cỏ X (Chai lẻ)", 95000m);
            loHangXuatKho.Add(thuocDietCo);

            // 4. Hiển thị cấu trúc Lô hàng và tính tổng tiền
            Console.WriteLine("--- CHI TIẾT CẤU TRÚC LÔ HÀNG ---");
            Console.WriteLine(loHangXuatKho.DisplayInfo());

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"TỔNG GIÁ TRỊ LÔ HÀNG: {loHangXuatKho.CalculateTotalPrice():N0} VND");

            // Client cũng có thể thao tác với một thùng hàng nhỏ một cách độc lập
            Console.WriteLine($"Tổng giá trị Thùng thuốc trừ sâu: {thungThuocTruSau.CalculateTotalPrice():N0} VND");

            Console.ReadLine();
        }
    }
}