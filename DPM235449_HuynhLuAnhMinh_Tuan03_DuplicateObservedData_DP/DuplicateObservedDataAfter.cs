using System;

namespace AnGiangPesticideRefactoring
{
    // Lớp Domain Model chuyên quản lý dữ liệu miền nghiệp vụ độc lập
    public class PesticideInventoryDomainModel
    {
        private int quantity;
        public event Action<int> OnQuantityChanged;

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0) throw new ArgumentException("So luong khong duoc am!");
                quantity = value;
                OnQuantityChanged?.Invoke(quantity); // Thông báo thay đổi cho UI
            }
        }
    }

    // Lớp giao diện (UI) đồng bộ dữ liệu thông qua Observer
    public class DuplicateObservedDataAfter
    {
        private PesticideInventoryDomainModel inventoryModel;
        public string QuantityBoxValue { get; private set; }

        public DuplicateObservedDataAfter(PesticideInventoryDomainModel model)
        {
            inventoryModel = model;
            // Đăng ký nhận sự kiện thay đổi dữ liệu từ Domain Model
            inventoryModel.OnQuantityChanged += UpdateUIField;
            QuantityBoxValue = inventoryModel.Quantity.ToString();
        }

        private void UpdateUIField(int newQty)
        {
            QuantityBoxValue = newQty.ToString();
            Console.WriteLine($"[UI Sync After] Giao dien da duoc cap nhat tu Dong Model: {QuantityBoxValue}");
        }

        public void SetInventoryQuantityFromUI(int newQty)
        {
            inventoryModel.Quantity = newQty; // Thay đổi dữ liệu ở Domain
        }
    }
}