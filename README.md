# ĐỒ ÁN BẢO TRÌ VÀ PHÁT TRIỂN PHẦN MỀM
## HỆ THỐNG QUẢN LÝ BÁN HÀNG CÔNG TY NÔNG DƯỢC AN GIANG

---

### 📋 THÔNG TIN CHUNG
* **Trường:** Đại học An Giang – ĐHQG TP.HCM
* **Môn học:** Thiết kế Phát triển và Bảo trì Phần mềm
* **Học phần / Lớp:** DPM235449
* **Sinh viên thực hiện:** Huỳnh Lư Anh Minh
* **Công nghệ sử dụng:** C# (.NET Console Application)
* **Kiến trúc & Mẫu thiết kế:** Creational Design Patterns (Gang of Four - GoF)

---

### 🎯 BỐI CẢNH VÀ MỤC TIÊU ĐỀ TÀI
Công ty Nông dược An Giang tiến hành bảo trì và nâng cấp phần mềm quản lý bán hàng nhằm khắc phục các hạn chế hiện tại (lỗi nhỏ không rõ nguyên nhân, chưa hỗ trợ tính chi phí vận chuyển/dịch vụ phụ, thống kê chưa đầy đủ, chưa có hệ thống phân quyền đăng nhập). 

Đồ án ứng dụng **5 mẫu thiết kế thuộc nhóm Khởi tạo (Creational Design Patterns)** để tái cấu trúc (Refactoring) và mở rộng hệ thống theo đúng quy trình nghiệp vụ kinh doanh nông dược.

---

### 📂 CẤU TRÚC MÃ NGUỒN VÀ BÀI TOÁN ÁP DỤNG

Tất cả các mẫu thiết kế được đóng gói và tổ chức gọn gàng trong thư mục `Design_Patterns/` với các bài toán thực tế tương ứng:

#### 1. Abstract Factory Pattern (`AbstractFactory`)
* **Nghiệp vụ:** Cấu hình linh hoạt phương pháp quản lý bán hàng (Bán Sỉ vs Bán Lẻ).
* **Ứng dụng:**
  * **Tính giá xuất kho:** Tùy chọn giữa *Bình quân gia quyền* hoặc *Nhập trước xuất trước (FIFO)*.
  * **Quy tắc xuất kho:** Tự động ưu tiên xuất lô có *Hạn sử dụng gần nhất* hoặc xuất theo *Lô chỉ định* của thủ kho.

#### 2. Factory Method Pattern (`FactoryMethod`)
* **Nghiệp vụ:** Quản lý các chi phí phát sinh khi lập hóa đơn bán hàng.
* **Ứng dụng:** Khởi tạo động các loại dịch vụ cộng thêm bao gồm *Chi phí vận chuyển nông dược* (miễn phí cho đơn hàng lớn) và *Dịch vụ phụ* (tư vấn kỹ thuật phun thuốc bảo vệ thực vật).

#### 3. Builder Pattern (`Builder`)
* **Nghiệp vụ:** Lập hóa đơn bán hàng phức tạp với nhiều thành phần chi tiết.
* **Ứng dụng:** Xây dựng từng bước đối tượng Hóa đơn (`SalesInvoice`) chứa danh sách sản phẩm, phí vận chuyển, phí dịch vụ phụ và áp dụng các khoản chiết khấu/giảm giá khuyến mãi.

#### 4. Prototype Pattern (`Prototype`)
* **Nghiệp vụ:** Nhập hàng nông dược theo lô tại kho.
* **Ứng dụng:** Sử dụng cơ chế Sao chép sâu (`DeepCopy`) để nhân bản nhanh thông tin lô hàng mẫu (Tên sản phẩm, Nhà cung cấp, Giá nhập) mà vẫn đảm bảo tính độc lập về Số lô (`BatchCode`) và Hạn sử dụng (`ExpiryDate`).

#### 5. Singleton Pattern (`Singleton`)
* **Nghiệp vụ:** Quản lý phiên đăng nhập và phân quyền nhân viên bán hàng.
* **Ứng dụng:** Đảm bảo duy nhất một thể hiện `UserSessionManager` tồn tại trong suốt vòng đời ứng dụng, hỗ trợ an toàn trong môi trường đa luồng (Thread-safe Double-Check Locking).

---

### 🚀 HƯỚNG DẪN CHẠY DỰ ÁN

1. **Yêu cầu môi trường:**
   * Visual Studio 2022 (hoặc VS Code) đã cài đặt `.NET SDK` (.NET 6.0 / .NET 8.0 trở lên).
2. **CÁCH THỰC THI:**
   * Mở dự án trong Visual Studio.
   * Mở tệp `Program.cs` và nhấn **F5** (hoặc `Ctrl + F5`) để biên dịch và chạy kịch bản thử nghiệm console cho cả 5 mẫu thiết kế.

---

### 📑 ĐỊNH HƯỚNG BẢO TRÌ VÀ PHÁT TRIỂN TƯƠNG LAI
* **Áp dụng ISO/IEC/IEEE 14764:** Chuẩn hóa quy trình tiếp nhận thông tin lỗi, phản hồi và nâng cấp phần mềm bảo trì.
* **Mở rộng Mẫu thiết kế:** Áp dụng đầy đủ 23 GOF Design Patterns (Structural & Behavioral Patterns) vào hệ thống.
* **Kiểm thử & Đảo ngược:** Ứng dụng công cụ Alvota UML / Doxygen để đảo ngược thiết kế và Datatect / QuickTest Pro cho kiểm thử tự động.# Thiet_Ke_Phat_Trien_Bao_Tri_Phan_Mem
