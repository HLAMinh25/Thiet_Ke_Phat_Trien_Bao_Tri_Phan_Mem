using System;

namespace AnGiangPesticideRefactoring
{
    // Domain Model chứa logic tính toán tiền hàng của hóa đơn nông dược
    public class InvoiceCalculationDomainModel
    {
        private int quantity;
        private double unitPrice;

        public event Action<double> OnTotalAmountChanged;

        public int Quantity
        {
            get => quantity;
            set { quantity = value; Recalculate(); }
        }

        public double UnitPrice
        {
            get => unitPrice;
            set { unitPrice = value; Recalculate(); }
        }

        public double TotalAmount { get; private set; }

        public InvoiceCalculationDomainModel(int initialQty, double unitPrice)
        {
            this.quantity = initialQty;
            this.unitPrice = unitPrice;
            Recalculate();
        }

        private void Recalculate()
        {
            TotalAmount = quantity * unitPrice;
            OnTotalAmountChanged?.Invoke(TotalAmount); // Bắn sự kiện cập nhật tiền
        }
    }

    // Class Real: Giao diện Form Bán Hàng Nông Dược An Giang áp dụng Duplicate Observed Data
    public class DuplicateObservedDataReal
    {
        private InvoiceCalculationDomainModel invoiceModel;
        public string UIQuantityInput { get; private set; }
        public string UITotalAmountLabel { get; private set; }

        public DuplicateObservedDataReal(InvoiceCalculationDomainModel model)
        {
            invoiceModel = model;
            // Lắng nghe sự kiện thay đổi tổng tiền từ Domain Model để đồng bộ nhãn trên Form
            invoiceModel.OnTotalAmountChanged += SyncTotalAmountToUI;

            UIQuantityInput = invoiceModel.Quantity.ToString();
            UITotalAmountLabel = $"{invoiceModel.TotalAmount:N0} VND";
        }

        private void SyncTotalAmountToUI(double newTotal)
        {
            UITotalAmountLabel = $"{newTotal:N0} VND";
            Console.WriteLine($"[Form Ban Hang An Giang] Nhap lieu thay doi -> Cap nhat Label Tong Tien tren UI: {UITotalAmountLabel}");
        }

        // Giả lập nhân viên bán hàng thay đổi số lượng thuốc xuất kho trên giao diện Form
        public void UserChangedQuantityOnForm(int newQuantity)
        {
            UIQuantityInput = newQuantity.ToString();
            invoiceModel.Quantity = newQuantity; // Cập nhật sang Model nghiệp vụ
        }
    }
}