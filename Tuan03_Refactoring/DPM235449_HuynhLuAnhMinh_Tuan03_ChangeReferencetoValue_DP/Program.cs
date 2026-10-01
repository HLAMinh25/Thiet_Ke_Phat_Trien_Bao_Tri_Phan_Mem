using System;

namespace AnGiangPesticideRefactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHAY THU NGHIEM: CHANGE REFERENCE TO VALUE ===");

            // 1. Test Before
            var currRef1 = new CurrencyRateBefore("VND", 1.0);
            var currRef2 = new CurrencyRateBefore("VND", 1.0);
            // Khác vùng nhớ (Reference) dù giá trị giống nhau
            bool isEqualBefore = (currRef1 == currRef2);
            Console.WriteLine($"1. Ket qua Before (So sanh tham chieu bang nhau?): {isEqualBefore}");

            // 2. Test After
            var currVal1 = new CurrencyRateValueAfter("VND", 1.0);
            var currVal2 = new CurrencyRateValueAfter("VND", 1.0);
            // Bằng nhau về mặt giá trị nhờ ghi đè Equals (Value Object)
            bool isEqualAfter = currVal1.Equals(currVal2);
            Console.WriteLine($"2. Ket qua After (So sanh gia tri bang nhau?): {isEqualAfter}");

            // 3. Test Real (Nghiệp vụ hoạt chất thuốc bảo vệ thực vật An Giang)
            var activeIngA = new ActiveIngredientValueObject("Benomyl", "50WP");
            var activeIngB = new ActiveIngredientValueObject("Benomyl", "50WP");

            var pesticideProduct = new ChangeReferenceToValueReal("BVTV-999", "Thuoc Tru Sau Benlate C", activeIngA);

            Console.WriteLine("\n3. Ket qua Real:");
            pesticideProduct.PrintProductDetails();

            // Kiểm tra xem 2 đối tượng hoạt chất riêng biệt có tương đương nhau về giá trị không
            bool areIngredientsEquivalent = activeIngA.Equals(activeIngB);
            Console.WriteLine($"-> Hai hoat chat co tuong duong nhau ve gia tri (Value Object) khong?: {areIngredientsEquivalent}");

            Console.ReadKey();
        }
    }
}