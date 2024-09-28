# Hệ thống quản lý sự kiện.

## 1. **Giới thiệu**
### 1.1 Mục tiêu dự án
Xây dựng một nền tảng quản lý sự kiện, hỗ trợ tổ chức, quản lý sự kiện và bán vé trực tuyến. Ứng dụng cung cấp các tính năng như tạo sự kiện, đăng ký người dùng, đặt vé, tích hợp thanh toán và công cụ quảng bá sự kiện.

### 1.2 Phạm vi dự án
Ứng dụng sẽ phục vụ các nhà tổ chức sự kiện và người tham gia. Các tính năng chính bao gồm:
- Tạo và quản lý sự kiện.
- Đặt vé trực tuyến.
- Đăng ký và quản lý tài khoản người dùng.
- Tích hợp thanh toán trực tuyến.
- Công cụ quảng bá sự kiện thông qua email, mạng xã hội, và thông báo đẩy.

## 2. **Chức năng chính**
### 2.1 Quản lý sự kiện
- **Tạo sự kiện mới**: Người tổ chức có thể tạo sự kiện, điền thông tin như tên sự kiện, mô tả, thời gian, địa điểm, số lượng vé, giá vé, và loại vé. 🟢 Cần thiết. Đây là chức năng cốt lõi để người tổ chức sự kiện có thể tạo và đăng thông tin sự kiện.
- **Chỉnh sửa/xóa sự kiện**: Quản trị viên có thể chỉnh sửa hoặc xóa các sự kiện đã tạo. 🟢 Cần thiết. Cho phép quản trị viên thay đổi thông tin hoặc xóa sự kiện khi cần.
- **Quản lý lịch sử sự kiện**: Lưu trữ các sự kiện đã tổ chức, bao gồm thông tin về số vé bán ra, người tham gia, và doanh thu. 🟡 Có cũng tốt. Dữ liệu lịch sử giúp theo dõi sự kiện đã tổ chức, nhưng có thể bổ sung sau.

### 2.2 Đặt vé
- **Xem chi tiết sự kiện**: Người dùng có thể duyệt và xem các thông tin chi tiết về sự kiện. 🟢 Cần thiết. Người dùng cần thông tin chi tiết để quyết định tham gia.
- **Đặt vé**: Người dùng có thể chọn số lượng vé và loại vé, sau đó tiến hành đặt vé. 🟢 Cần thiết. Đây là chức năng quan trọng để bán vé cho sự kiện.
- **Xác nhận đặt vé qua email**: Sau khi đặt vé thành công, người dùng nhận email xác nhận cùng với mã QR để sử dụng khi tham dự sự kiện. 🟢 Cần thiết. Việc xác nhận vé giúp người dùng yên tâm về giao dịch và dễ quản lý vé.


### 2.3 Đăng ký và đăng nhập người dùng
- **Đăng ký tài khoản**: Người dùng mới có thể tạo tài khoản bằng email hoặc thông qua tài khoản Google. 🟢 Cần thiết. Người dùng cần đăng ký để sử dụng các tính năng đặt vé và quản lý sự kiện.
- **Đăng nhập**: Người dùng đã có tài khoản có thể đăng nhập bằng email, mật khẩu hoặc tài khoản xã hội. 🟢 Cần thiết. Chức năng này là phần cơ bản của mọi hệ thống cần quản lý tài khoản.
- **Quản lý thông tin cá nhân**: Người dùng có thể chỉnh sửa thông tin cá nhân, xem lịch sử đặt vé và sự kiện đã tham gia. 🟡 Có cũng tốt. Người dùng có thể cần chỉnh sửa thông tin, nhưng có thể bổ sung sau nếu cần.

### 2.4 Tích hợp thanh toán
- **Thanh toán trực tuyến**: Hỗ trợ nhiều phương thức thanh toán như thẻ tín dụng, ví điện tử, và chuyển khoản ngân hàng. 🟢 Cần thiết. Đây là một phần quan trọng để hoàn thành quá trình đặt vé.
- **Xử lý thanh toán an toàn**: Sử dụng SSL và các giao thức bảo mật khác để đảm bảo an toàn trong quá trình thanh toán. 🟢 Cần thiết. Bảo mật trong thanh toán là yếu tố sống còn cho bất kỳ ứng dụng giao dịch trực tuyến nào
- **Hóa đơn điện tử**: Người dùng có thể nhận hóa đơn sau khi hoàn tất giao dịch mua vé. 🟡 Có cũng tốt. Hóa đơn điện tử là bổ sung tốt, nhưng có thể phát triển sau khi các tính năng cơ bản đã ổn định.

### 2.5 Công cụ quảng bá sự kiện
- **Gửi email thông báo**: Tự động gửi email quảng bá sự kiện đến người dùng đăng ký hoặc danh sách liên hệ của nhà tổ chức. 🟡 Có cũng tốt. Chức năng này hỗ trợ quảng bá sự kiện, nhưng không bắt buộc trong giai đoạn đầu.
- **Chia sẻ lên mạng xã hội**: Cho phép người dùng chia sẻ sự kiện lên các nền tảng mạng xã hội như Facebook, Twitter, và LinkedIn. 🟡 Có cũng tốt. Chia sẻ sự kiện giúp tăng lượng người tham gia, nhưng có thể bổ sung sau.
- **Thông báo đẩy**: Gửi thông báo trực tiếp đến ứng dụng di động của người dùng về các sự kiện sắp diễn ra hoặc khuyến mãi đặc biệt.🔴 Không cần thiết ngay. Đây là tính năng cao cấp và không bắt buộc trong giai đoạn đầu của ứng dụng.

### 2.6 Báo cáo và phân tích (làm sau)

## 3. **Các công nghệ sử dụng**
- **Front-end**: HTML/CSS, JavaScript, Razor Pages.
- **Back-end**: ASP.NET Core MVC.
- **Database**: MySQL hoặc SQL Server.
- **Payment Gateway**: VNPay, Momo, Paypal, Stripe.
- **Hosting & Deployment**: AWS, Azure hoặc Heroku.
- **Version control**: Git và Github.
### 3.1 Mô hình kiến trúc
- **Frontend-Backend**: Sử dụng ASP.NET Core MVC kết hợp với service-repository pattern.
- **Database**: Sử dụng SQL Server hoặc MySQL để lưu trữ thông tin người dùng, sự kiện, vé, và thanh toán.
- **Payment Gateway**: Tích hợp với các dịch vụ thanh toán như VNPay, Momo, Paypal hoặc Stripe

### 3.2 Triển khai
- **Cloud Hosting**: AWS, Azure hoặc Heroku.
- **Quản lý phiên**: Sử dụng Git cho việc quản lý mã nguồn

## 4. **Bảo mật**
- **Quản lý quyền truy cập**: Phân quyền cho người tổ chức sự kiện và người dùng thường.
- **Mã hóa dữ liệu**: Sử dụng mã hóa dữ liệu trong quá trình truyền tải và lưu trữ thông tin nhạy cảm.
- **Xác thực 2 lớp (2FA)**: Tùy chọn xác thực 2 lớp cho người dùng để bảo vệ tài khoản. [optional]
- **Bảo mật giao dịch thanh toán**: Tích hợp các công nghệ bảo mật như PCI-DSS để đảm bảo an toàn trong giao dịch.

## 5. **Chạy thử và kiểm thử**
- **Kiểm thử đơn vị (Unit Test)**: Đảm bảo các module hoạt động chính xác.
- **Kiểm thử tích hợp (Integration Test)**: Kiểm tra các tương tác giữa các module và hệ thống.
- **Kiểm thử bảo mật (Security Test)**: Đảm bảo hệ thống không dễ bị tấn công bảo mật.
