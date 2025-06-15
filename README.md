# Humanizer - Thư viện mạnh mẽ xử lý ngôn ngữ tự nhiên trong .NET

**Humanizer** là một thư viện .NET mạnh mẽ, giúp đơn giản hóa việc xử lý chuỗi, số, ngày tháng và enum theo cách tự nhiên và dễ hiểu. Thư viện này thường được sử dụng để tạo các đầu ra thân thiện với người dùng, từ mô tả thời gian đến các thao tác với chuỗi văn bản.

## Tính năng nổi bật

- **Humanize thời gian**: Hiển thị thời gian ở định dạng ngôn ngữ tự nhiên, ví dụ: "2 giờ trước" hoặc "trong 3 ngày".
- **Chuyển số thành chữ**: Dễ dàng chuyển đổi số nguyên và số thập phân thành chữ.
- **Số ít và số nhiều**: Xử lý dạng số ít và số nhiều của từ một cách tự động.
- **Chuyển đổi số thứ tự**: Hiển thị số dưới dạng thứ tự, ví dụ: `21 => 21st`.
- **Humanize enum**: Chuyển enum thành dạng văn bản dễ đọc.
- **Rút gọn chuỗi**: Rút ngắn chuỗi văn bản một cách thông minh.
- **Chuyển đổi định dạng chuỗi**: Hỗ trợ các định dạng như PascalCase, camelCase, kebab-case, v.v.
- **Viết hoa tiêu đề (Titleize)**: Biến văn bản thành dạng tiêu đề.
- **Format TimeSpan**: Hiển thị khoảng thời gian ở định dạng dễ hiểu.
- **Dehumanize**: Chuyển ngược từ dạng ngôn ngữ tự nhiên sang định dạng gốc.
- **Romanize**: Chuyển số thành số La Mã, ví dụ: `42 => XLII`.
- **Tạo danh sách đọc được**: Tạo danh sách thân thiện từ mảng hoặc tập hợp.

---

## Cách cài đặt

Thư viện này có thể dễ dàng được thêm vào dự án .NET của bạn bằng lệnh sau:

```bash
dotnet add package Humanizer
```
## Cách sử dụng
Dưới đây là một số ví dụ cơ bản về cách sử dụng thư viện Humanizer trong dự án .NET của bạn: 

## **Demo và Kết quả**

### **Kết quả Chương trình**

```plaintext
=== Humanizer Demo ===

--- Humanize Thời gian ---
Quá khứ: 2 hours ago
Tương lai: in 3 days

--- ToWords (Chuyển số thành chữ) ---
Số nguyên: 12345 => twelve thousand three hundred forty-five
Số thập phân: 12345.67 => twelve thousand three hundred forty-five point sixty-seven

--- Số ít và số nhiều ---
Số ít: car => cars
Số nhiều: buses => bus

--- Số thứ tự ---
Ordinalize: 21 => 21st

--- Humanize Enum ---
Enum: My Second Value

--- Rút gọn chuỗi ---
Chuỗi rút gọn: This is a very lo...

--- Chuyển đổi định dạng chuỗi ---
PascalCase: ThisIsSampleText
camelCase: thisIsSampleText
kebab-case: this-is-sample-text

--- Viết hoa tiêu đề ---
Titleize: This Is A Title

--- Format TimeSpan ---
TimeSpan: 2 hours, 15 minutes

--- Dehumanize ---
Dehumanize: three days ago => 3 days ago

--- Romanize ---
Romanize: 42 => XLII
```
# Ý nghĩa của các đầu ra của Humanizer

Humanizer cung cấp nhiều tính năng hữu ích cho .NET, giúp chuyển đổi dữ liệu thành các định dạng dễ hiểu và thân thiện với người dùng. Dưới đây là ý nghĩa của từng loại đầu ra mà thư viện cung cấp:

---

### **Humanize Thời gian**
- **Quá khứ**: Chuyển đổi thời gian trong quá khứ thành chuỗi tự nhiên, dễ hiểu.  
  **Ví dụ**: `DateTime.Now.AddHours(-2).Humanize()` => `"2 hours ago"`

- **Tương lai**: Hiển thị thời gian trong tương lai với cú pháp tương tự.  
  **Ví dụ**: `DateTime.Now.AddDays(3).Humanize()` => `"in 3 days"`

---

### **ToWords (Chuyển số thành chữ)**
- **Số nguyên**: Chuyển đổi số nguyên thành chữ tiếng Anh.  
  **Ví dụ**: `12345.ToWords()` => `"twelve thousand three hundred forty-five"`

- **Số thập phân**: Chuyển đổi cả phần nguyên và phần lẻ của số thập phân.  
  **Ví dụ**: `12345.67m.ToWords()` => `"twelve thousand three hundred forty-five point sixty-seven"`

---

### **Số ít và Số nhiều**
- **Số ít**: Thêm hậu tố để chuyển từ số ít thành số nhiều.  
  **Ví dụ**: `"car".Pluralize()` => `"cars"`

- **Số nhiều**: Loại bỏ hậu tố để chuyển từ số nhiều về số ít.  
  **Ví dụ**: `"buses".Singularize()` => `"bus"`

---

### **Số thứ tự**
- Chuyển đổi số nguyên thành dạng số thứ tự.  
  **Ví dụ**: `21.Ordinalize()` => `"21st"`

---

### **Humanize Enum**
- Chuyển Enum thành chuỗi thân thiện với người dùng, giữ nguyên ý nghĩa của các giá trị.  
  **Ví dụ**: `MyEnum.MySecondValue.Humanize()` => `"My Second Value"`

---

### **Rút gọn chuỗi**
- Rút ngắn chuỗi dài nhưng vẫn giữ nội dung dễ hiểu.  
  **Ví dụ**: `"This is a very long string".Truncate(20)` => `"This is a very lo..."`

---

### **Chuyển đổi định dạng chuỗi**
- **PascalCase**: Định dạng Pascal cho văn bản.  
  **Ví dụ**: `"this is sample text".Pascalize()` => `"ThisIsSampleText"`

- **camelCase**: Định dạng camel cho văn bản.  
  **Ví dụ**: `"this is sample text".Camelize()` => `"thisIsSampleText"`

- **kebab-case**: Định dạng kebab-case cho văn bản.  
  **Ví dụ**: `"this is sample text".Kebaberize()` => `"this-is-sample-text"`

---

### **Viết hoa tiêu đề**
- Chuyển đổi văn bản thành tiêu đề với mỗi từ được viết hoa.  
  **Ví dụ**: `"this is a title".Titleize()` => `"This Is A Title"`

---

### **Format TimeSpan**
- Hiển thị TimeSpan dưới dạng chuỗi thân thiện.  
  **Ví dụ**: `TimeSpan.FromMinutes(135).Humanize()` => `"2 hours, 15 minutes"`

---

### **Dehumanize**
- Chuyển chuỗi tự nhiên ngược lại thành dữ liệu dạng chuẩn.  
  **Ví dụ**: `"three days ago".Dehumanize()` => `"3 days ago"`

---

### **Romanize**
- Chuyển đổi số nguyên thành số La Mã.  
  **Ví dụ**: `42.ToRoman()` => `"XLII"`

--- 
### **Tạo danh sách đọc được**
- Chuyển mảng hoặc tập hợp thành chuỗi danh sách dễ đọc.  
  **Ví dụ**: `new[] { "apple", "banana", "cherry" }.ToReadableList()` => `"apple, banana, and cherry"`
---

## Cách chạy chương trình
Để chạy chương trình, bạn có thể sử dụng Visual Studio hoặc bất kỳ IDE nào hỗ trợ .NET. Dưới đây là các bước cơ bản:
1. Clone hoặc tải xuống mã nguồn từ kho lưu trữ GitHub.
2. Mở dự án trong Visual Studio hoặc IDE của bạn.
3. Chạy chương trình bằng cách chạy dotnet run vì bài này là console app.
4. Xem kết quả trên cửa sổ console.
Program dự án :[Code Humanize](https://github.com/EduHub-LHU/Humanizer.NET/blob/main/Program.cs)
## Yêu cầu hệ thống
- .NET 6.0 trở lên
- Visual Studio 2019 hoặc mới hơn (hoặc bất kỳ IDE nào hỗ trợ .NET)
## Tài liệu tham khảo
- [Humanizer Documentation](https://github.com/Humanizr/Humanizer)
- [Humanizer trên NuGet](https://www.nuget.org/packages/Humanizer)
## Đóng góp
Nếu bạn muốn đóng góp vào dự án này, xin vui lòng tạo một pull request hoặc mở issue trên GitHub. Mọi ý kiến đóng góp đều được hoan nghênh!
## Giấy phép
Thư viện Humanizer được phát hành dưới giấy phép [MIT License](https://opensource.org/licenses/MIT). Bạn có thể tự do sử dụng, sửa đổi và phân phối thư viện này trong các dự án của mình.
## Liên hệ      
Nếu bạn có bất kỳ câu hỏi nào hoặc cần hỗ trợ, hãy liên hệ với chúng tôi qua email hoặc thông qua trang GitHub của dự án.
## Kết luận
Humanizer là một thư viện hữu ích cho các nhà phát triển .NET, giúp đơn giản hóa việc xử lý chuỗi và dữ liệu theo cách tự nhiên và dễ hiểu. Với nhiều tính năng mạnh mẽ, Humanizer sẽ giúp bạn tạo ra các ứng dụng thân thiện với người dùng hơn.
