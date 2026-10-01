using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    public class RemoveControlFlagAfter
    {
        public void SearchProductInStock(List<string> productList, string targetProduct)
        {
            foreach (var product in productList)
            {
                if (product.Equals(targetProduct, StringComparison.OrdinalIgnoreCase))
                {
                    // Sử dụng trực tiếp từ khóa return thay vì dùng biến cờ hiệu
                    Console.WriteLine($"[After] Da tim thay san pham '{targetProduct}' trong kho!");
                    return;
                }
            }

            Console.WriteLine($"[After] Khong tim thay san pham '{targetProduct}'!");
        }
    }
}