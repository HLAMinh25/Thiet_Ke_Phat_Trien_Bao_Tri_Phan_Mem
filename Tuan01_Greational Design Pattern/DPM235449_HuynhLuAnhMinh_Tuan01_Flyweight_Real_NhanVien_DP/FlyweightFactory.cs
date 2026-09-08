using System;
using System.Collections.Generic;
using System.Linq;

namespace NongDuocAnGiang.DesignPatterns.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, InventoryFlyweight> _flyweights = new Dictionary<string, InventoryFlyweight>();

        public FlyweightFactory(params ProductSharedState[] initialStates)
        {
            foreach (var state in initialStates)
            {
                _flyweights.Add(GetKey(state), new InventoryFlyweight(state));
            }
        }

        // Tạo khóa định danh dựa trên dữ liệu chung
        private string GetKey(ProductSharedState key)
        {
            return $"{key.ProductName}_{key.Category}_{key.Unit}";
        }

        public InventoryFlyweight GetFlyweight(ProductSharedState sharedState)
        {
            string key = GetKey(sharedState);

            if (!_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"\n[Factory] Không tìm thấy Flyweight cho '{sharedState.ProductName}'. Đang tạo mới...");
                _flyweights.Add(key, new InventoryFlyweight(sharedState));
            }
            else
            {
                Console.WriteLine($"\n[Factory] Tái sử dụng Flyweight đã có cho '{sharedState.ProductName}'.");
            }

            return _flyweights[key];
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"\n--- Cache hiện tại đang chứa {_flyweights.Count} Flyweights ---");
            foreach (var key in _flyweights.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}