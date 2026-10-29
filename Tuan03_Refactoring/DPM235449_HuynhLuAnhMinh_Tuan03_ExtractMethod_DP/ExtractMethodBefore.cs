using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractMethodBefore
    {
        private string name = "Thuoc tru sau An Giang";
        private double outstanding = 150000;

        // Code gốc theo mẫu cơ bản của Refactoring.Guru (Long Method)
        public void PrintOwing()
        {
            PrintBanner();

            // In chi tiết hóa đơn (Code fragment cần extract)
            Console.WriteLine("// --- Chi tiet hoa don ban hang ---");
            Console.WriteLine("name: " + name);
            Console.WriteLine("amount: " + GetOutstanding());
        }

        private void PrintBanner()
        {
            Console.WriteLine("================================");
            Console.WriteLine("   CONG TY NONG DUOC AN GIANG   ");
            Console.WriteLine("================================");
        }

        private double GetOutstanding()
        {
            return this.outstanding;
        }
    }
}