using System;

namespace Bai3_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== BÀI 3: BUILDER - XÂY DỰNG HÓA ĐƠN ===\n");

            InvoiceDirector director = new InvoiceDirector();
            SalesInvoiceBuilder builder = new SalesInvoiceBuilder();

            director.BuildPromotionInvoice(builder, "NV001");
            SalesInvoice invoice = builder.GetInvoice();

            invoice.Display();

            Console.ReadLine();
        }
    }
}