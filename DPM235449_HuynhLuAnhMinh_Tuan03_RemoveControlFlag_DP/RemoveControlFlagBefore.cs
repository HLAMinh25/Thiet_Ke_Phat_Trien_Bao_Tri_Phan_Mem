using System;
using System.Collections.Generic;

namespace AnGiangPesticideRefactoring
{
    public class RemoveControlFlagBefore
    {
        public void SearchProductInStock(List<string> productList, string targetProduct)
        {
            bool foundFlag = false; // Biến cờ hiệu điều khiển luồng

            foreach (var product in productList)
            {
                if (!foundFlag)
                {
                    if (product.Equals(targetProduct, StringComparison.OrdinalIgnoreCase))
                    {
                        foundFlag = true; // Bật cờ hiệu khi tìm thấy
                        Console.WriteLine($"[Before] Da tim thay san pham '{targetProduct}' trong kho!");
                    }
                }
            }

            if (!foundFlag)
            {
                Console.WriteLine($"[Before] Khong tim thay san pham '{targetProduct}'!");
            }
        }
    }
}