using System;
using System.Text.Json;

namespace RefactoringGuru.DesignPatterns.Flyweight.Conceptual
{
    // Lưu trữ phần trạng thái dùng chung (Intrinsic state) giữa các đối tượng
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonSerializer.Serialize(this._sharedState);
            string u = JsonSerializer.Serialize(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}