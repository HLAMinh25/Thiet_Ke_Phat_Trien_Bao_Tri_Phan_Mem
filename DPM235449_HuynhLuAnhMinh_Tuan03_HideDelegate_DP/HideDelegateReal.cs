using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp chứa chứng nhận kiểm định chất lượng lô thuốc nông dược
    public class QualityControlCertificate
    {
        public string CertificateCode { get; set; }
        public DateTime IssuedDate { get; set; }
        public string InspectorName { get; set; }

        public QualityControlCertificate(string code, DateTime issuedDate, string inspector)
        {
            CertificateCode = code;
            IssuedDate = issuedDate;
            InspectorName = inspector;
        }

        public string GetInspectionSummary()
        {
            return $"Ma chung nhan: {CertificateCode} (Kiem dinh boi: {InspectorName} - Ngay: {IssuedDate:dd/MM/yyyy})";
        }
    }

    // Lớp quản lý lô hàng nông dược
    public class PesticideBatchRecord
    {
        public string BatchId { get; set; }
        private QualityControlCertificate qcCertificate;

        public PesticideBatchRecord(string batchId, QualityControlCertificate qcCertificate)
        {
            BatchId = batchId;
            this.qcCertificate = qcCertificate;
        }

        public QualityControlCertificate GetQCCertificate()
        {
            return qcCertificate;
        }
    }

    // Class Real: Hóa đơn bán hàng áp dụng Hide Delegate
    public class HideDelegateReal
    {
        public string InvoiceCode { get; set; }
        public PesticideBatchRecord BatchRecord { get; set; }

        public HideDelegateReal(string invoiceCode, PesticideBatchRecord batchRecord)
        {
            InvoiceCode = invoiceCode;
            BatchRecord = batchRecord;
        }

        // Áp dụng Hide Delegate: Ẩn đi cấu trúc phức tạp bên trong BatchRecord bằng một hàm ủy quyền gọn gàng
        public string GetBatchInspectionSummary()
        {
            return BatchRecord.GetQCCertificate().GetInspectionSummary();
        }

        public void PrintInvoiceWithQC()
        {
            Console.WriteLine($"[Hoa Don: {InvoiceCode}] Lo hang: {BatchRecord.BatchId}");
            Console.WriteLine($"-> Thong tin QC: {GetBatchInspectionSummary()}");
        }
    }
}