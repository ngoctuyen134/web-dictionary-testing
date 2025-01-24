# Kiểm thử tự động cho Dictionary.com
## Mô tả
Dự án bao gồm kiểm thử chức năng của các tính năng Đăng nhập và Tìm kiếm để đảm bảo tính chính xác và độ tin cậy.

## Tính năng
- **Kiểm thử Chức năng Đăng nhập**:
  - Kiểm thử đăng nhập thành công với thông tin xác thực hợp lệ.
  - Kiểm thử các tình huống đăng nhập thất bại:
    - Thiếu email.
    - Thiếu mật khẩu.
    - Email hoặc mật khẩu không hợp lệ.
- **Kiểm thử Chức năng Tìm kiếm**:
  - Kiểm thử tìm kiếm thành công với từ khóa hợp lệ.
  - Kiểm thử tìm kiếm thất bại với từ khóa không hợp lệ hoặc không tồn tại.

## Hướng dẫn Cài đặt
1. Cài đặt [Microsoft Visual Studio 2022](https://visualstudio.microsoft.com/) với hỗ trợ .NET Framework.
2. Cài đặt Selenium WebDriver và Selenium.WebDriver.ChromeDriver thông qua Trình quản lý gói NuGet.
3. Thêm một tệp dữ liệu (`TestLogin.csv` hoặc `TestSearch.csv`) vào thư mục `Data` và cấu hình để sao chép khi xây dựng.
4. Chạy các dự án Kiểm thử Đơn vị để thực thi các trường hợp kiểm thử.

## Công cụ và Công nghệ
- **Ngôn ngữ lập trình**: C#
- **Khung công tác**: .NET Framework
- **Công cụ kiểm thử**: Selenium WebDriver
- **IDE**: Microsoft Visual Studio 2022
- **Trình duyệt**: Google Chrome (Phiên bản 124.0.6367.92)

## Cấu trúc Dự án
- `TestLogin_72_Tuyen.cs`: Chứa các trường hợp kiểm thử cho chức năng đăng nhập.
- `TestSearch_72_Tuyen.cs`: Chứa các trường hợp kiểm thử cho chức năng tìm kiếm.
- `Data/TestLogin.csv`: Dữ liệu đầu vào cho kiểm thử đăng nhập.
- `Data/TestSearch.csv`: Dữ liệu đầu vào cho kiểm thử tìm kiếm.

## Kết quả
- **Kiểm thử Đăng nhập**: Bốn trường hợp kiểm thử đã được thực hiện, bao gồm cả các tình huống thành công và thất bại.
- **Kiểm thử Tìm kiếm**: Hai trường hợp kiểm thử đã được thực hiện cho kết quả tìm kiếm thành công và thất bại.
- Tổng cộng sáu trường hợp kiểm thử đã được chạy thành công.

## Cách Thực hiện
1. Mở giải pháp trong Visual Studio.
2. Điều hướng đến Test Explorer.
3. Chạy các trường hợp kiểm thử mong muốn hoặc tất cả các kiểm thử.



