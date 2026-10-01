using System;

namespace AnGiangPesticideRefactoring
{
    public class ExtractMethodAfter
    {
        private string name = "Thuoc tru sau An Giang";
        private double outstanding = 150000;

        // Code sau khi áp dụng Extract Method (Tách phần in chi tiết ra hàm riêng)
        public void PrintOwing()
        {
            PrintBanner();
            PrintDetails(GetOutstanding());
        }

        private void PrintDetails(double outstandingParam)
        {
            Console.WriteLine("// --- Chi tiet hoa don ban hang ---");
            Console.WriteLine("name: " + name);
            Console.WriteLine("amount: " + outstandingParam);
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