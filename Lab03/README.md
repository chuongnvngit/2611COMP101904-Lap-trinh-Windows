\# BUỔI 3 - LAB 03: QUẢN LÝ SINH VIÊN BẰNG CONSOLE (C# \& OOP)



\## 1. Giới thiệu tổng quan

Chương trình Console Application viết bằng ngôn ngữ \*\*C# (.NET)\*\* phục vụ quản lý sinh viên theo mô hình \*\*Lập trình Hướng đối tượng (OOP)\*\* kết hợp \*\*LINQ\*\*. Hệ thống cho phép thực hiện đầy đủ các thao tác CRUD, tra cứu, phân loại và sắp xếp dữ liệu thông qua Menu điều khiển.



\---



\## 2. Kiến trúc \& Thiết kế hướng đối tượng



Chương trình được tổ chức thành 4 file mã nguồn độc lập theo đúng cấu trúc chuẩn:



\### 2.1. Lớp `Nguoi.cs` (Base Class)

\- \*\*Thuộc tính\*\*: `HoTen` (string), `NgaySinh` (DateTime).

\- \*\*Constructor\*\*: Khởi tạo giá trị đầy đủ cho lớp cơ sở.

\- \*\*Phương thức\*\*: 

&#x20; - `virtual string LayThongTin()`: Trả về chuỗi thông tin gồm họ tên và ngày sinh (định dạng `dd/MM/yyyy`).



\### 2.2. Lớp `SinhVien.cs` (Derived Class)

\- Kế thừa trực tiếp từ lớp `Nguoi` qua cú pháp `: Nguoi`.

\- \*\*Thuộc tính bổ sung\*\*: 

&#x20; - `MaSinhVien` (string), `MaLop` (string).

&#x20; - `DiemTrungBinh` (double): Đóng gói trường dữ liệu (encapsulation) với ràng buộc chặt chẽ trong khoảng từ 0.0 đến 10.0 (ném ngoại lệ `ArgumentException` nếu nhập ngoài khoảng).

\- \*\*Constructor\*\*: Tái sử dụng constructor cha bằng từ khóa `: base(hoTen, ngaySinh)`.

\- \*\*Phương thức\*\*:

&#x20; - `string XepLoai()`: Tự động xếp loại học lực dựa trên điểm trung bình (Xuất sắc, Giỏi, Khá, Trung bình, Yếu).

&#x20; - `override string LayThongTin()`: Nối chuỗi thông tin kế thừa từ `base.LayThongTin()` cùng các thông tin riêng của sinh viên.



\### 2.3. Lớp `QuanLySinhVien.cs` (Service/Business Logic)

\- Đóng gói danh sách nội bộ `List<SinhVien>` để lưu trữ dữ liệu trong bộ nhớ, không cho phép lớp `Main` can thiệp trực tiếp vào danh sách.

\- \*\*Ứng dụng LINQ giải quyết bài toán\*\*:

&#x20; - `Any(...)`: Kiểm tra mã sinh viên đã tồn tại trước khi thêm mới (chống trùng mã).

&#x20; - `FirstOrDefault(...)`: Tìm kiếm chính xác 1 sinh viên theo mã.

&#x20; - `Where(...)`: Lọc các sinh viên có họ tên chứa từ khóa tìm kiếm.

&#x20; - `Where(sv => sv.DiemTrungBinh >= 5.0)`: Lọc danh sách sinh viên đạt chuẩn.

&#x20; - `OrderByDescending(sv => sv.DiemTrungBinh)`: Sắp xếp danh sách theo điểm giảm dần.



\### 2.4. Lớp `Program.cs` (UI \& Control Flow)

\- Quản lý vòng lặp Menu chính, điều hướng thao tác và gọi các phương thức nghiệp vụ từ `QuanLySinhVien`.

\- \*\*Xử lý ngoại lệ và an toàn dữ liệu đầu vào\*\*:

&#x20; - Khởi tạo biến điều khiển `chon = -1` để không bị thoát nhầm chương trình khi nhập sai dữ liệu.

&#x20; - Sử dụng `int.TryParse` để bắt lỗi nhập ký tự lạ ở Menu, báo lỗi đỏ và dùng `continue` để giữ vững ứng dụng.

&#x20; - Sử dụng `double.TryParse` kết hợp `CultureInfo.InvariantCulture` và `.Replace(',', '.')` để đọc đúng số thực ở cả 2 chuẩn dấu chấm và dấu phẩy.

&#x20; - Sử dụng `DateTime.TryParseExact` với định dạng `dd/MM/yyyy` để chặn lỗi ngày tháng không hợp lệ.



\---



\## 3. Các chức năng chính của chương trình



1\. \*\*Thêm sinh viên\*\*: Nhập đầy đủ thông tin; tự động kiểm tra trùng mã và kiểm tra khoảng điểm 0 - 10.

2\. \*\*Xuất danh sách\*\*: In toàn bộ danh sách sinh viên kèm xếp loại học lực.

3\. \*\*Tìm theo mã\*\*: Tìm chính xác mã không phân biệt hoa/thường.

4\. \*\*Tìm theo tên\*\*: Tìm theo từ khóa họ tên (sử dụng LINQ `Where`).

5\. \*\*Sửa điểm\*\*: Cập nhật lại điểm trung bình cho sinh viên theo mã chỉ định.

6\. \*\*Xóa sinh viên\*\*: Xóa sinh viên khỏi hệ thống dựa vào mã sinh viên.

7\. \*\*Sắp xếp theo điểm giảm dần\*\*: Xuất danh sách xếp hạng từ cao xuống thấp bằng LINQ.

8\. \*\*Lọc sinh viên đạt\*\*: Lọc và hiển thị các sinh viên có điểm ≥ 5.0 bằng LINQ.

0\. \*\*Thoát\*\*: Kết thúc ứng dụng.



\---



\## 4. Hướng dẫn chạy chương trình



1\. Mở file solution (`.sln`) của Lab03 bằng \*\*Visual Studio 2022\*\*.

2\. Nhấn \*\*F5\*\* (hoặc \*\*Ctrl + F5\*\*) để biên dịch và khởi chạy Console App.

3\. Nhập các số từ `0` đến `8` theo hướng dẫn của Menu để thao tác.



\---



\## 5. Kết quả chạy chương trình minh họa



1\. Chức năng thêm sinh viên mới:

!\[](images/themSV.png)



2\. Chức năng xuất toàn bộ danh sách sinh viên:

!\[](images/xuatDS.png)



3\. Bắt lỗi thêm trùng mã sinh viên:

!\[](images/loiThemTrungMaSV.png)



4\. Chức năng tìm sinh viên theo mã:

!\[](images/timTheoMa.png)



5\. Chức năng tìm sinh viên theo từ khóa tên:

!\[](images/timTheoTen.png)



6\. Chức năng sửa điểm trung bình sinh viên:

!\[](images/suaDiem.png)



7\. Xuất danh sách kiểm tra sau khi sửa điểm:

!\[](images/xuatDSSauSuaDiem.png)



8\. Chức năng xóa sinh viên khỏi danh sách:

!\[](images/xoaSV.png)



9\. Chức năng sắp xếp danh sách theo điểm giảm dần (LINQ):

!\[](images/sapXepGiamDan.png)



10\. Chức năng lọc danh sách sinh viên đạt chuẩn (LINQ):

!\[](images/locSV.png)

