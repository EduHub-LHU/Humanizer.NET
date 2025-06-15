using Humanizer;

namespace HumanizerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Humanizer Demo ===");

            // 1. Humanize thời gian
            Console.WriteLine("\n--- Humanize Thời gian ---");
            var pastDate = DateTime.Now.AddHours(-2);
            var futureDate = DateTime.Now.AddDays(3);
            Console.WriteLine($"Quá khứ: {pastDate.Humanize()}"); // Output: "2 hours ago"
            Console.WriteLine($"Tương lai: {futureDate.Humanize()}"); // Output: "in 3 days"

            // 2. Chuyển số thành chữ
            Console.WriteLine("\n--- ToWords (Chuyển số thành chữ) ---");
            int number = 12345;
            decimal decimalNumber = 12345.67m;
            Console.WriteLine($"Số nguyên: {number} => {number.ToWords()}"); // Output: "twelve thousand three hundred and forty-five"
            Console.WriteLine($"Số thập phân: {decimalNumber} => {DecimalToWords(decimalNumber)}");

            // 3. Pluralize và Singularize
            Console.WriteLine("\n--- Pluralize và Singularize ---");
            string singular = "car";
            string plural = "buses";
            Console.WriteLine($"Số ít: {singular} => {singular.Pluralize()}"); // Output: "cars"
            Console.WriteLine($"Số nhiều: {plural} => {plural.Singularize()}"); // Output: "bus"

            // 4. Ordinalize (Số thứ tự)
            Console.WriteLine("\n--- Ordinalize (Chuyển thành số thứ tự) ---");
            int ordinalNumber = 21;
            Console.WriteLine($"Ordinalize: {ordinalNumber} => {ordinalNumber.Ordinalize()}"); // Output: "21st"

            // 5. Humanize Enum
            Console.WriteLine("\n--- Humanize Enum ---");
            MyEnum exampleEnum = MyEnum.MySecondValue;
            Console.WriteLine($"Enum: {exampleEnum.Humanize()}"); // Output: "My Second Value"

            // 6. Truncate chuỗi
            Console.WriteLine("\n--- Truncate (Rút gọn chuỗi) ---");
            string longString = "This is a very long string that needs to be truncated.";
            Console.WriteLine($"Chuỗi rút gọn: {longString.Truncate(20)}"); // Output: "This is a very lo..."

            // 7. PascalCase, camelCase, kebab-case
            Console.WriteLine("\n--- Chuyển đổi định dạng chuỗi ---");
            string text = "This Is Sample Text";
            Console.WriteLine($"PascalCase: {text.Pascalize()}"); // Output: "ThisIsSampleText"
            Console.WriteLine($"camelCase: {text.Camelize()}");   // Output: "thisIsSampleText"
            Console.WriteLine($"kebab-case: {text.Kebaberize()}"); // Output: "this-is-sample-text"

            // 8. Titleize (Viết hoa tiêu đề)
            Console.WriteLine("\n--- Titleize ---");
            string lowerCaseText = "this is a title";
            Console.WriteLine($"Titleize: {lowerCaseText.Titleize()}"); // Output: "This Is A Title"

            // 9. Format TimeSpan
            Console.WriteLine("\n--- Format TimeSpan ---");
            TimeSpan timeSpan = TimeSpan.FromMinutes(135);
            Console.WriteLine($"TimeSpan: {timeSpan.Humanize()}"); // Output: "2 hours, 15 minutes"

            // 10. Dehumanize (Ngược lại với Humanize)
            Console.WriteLine("\n--- Dehumanize ---");
            string humanized = "three days ago";
            Console.WriteLine($"Dehumanize: {humanized} => {humanized.Dehumanize()}");

            // 11. ToQuantity (Số lượng với số ít/số nhiều)
            Console.WriteLine("\n--- ToQuantity ---");
            Console.WriteLine($"Số ít: {"car".ToQuantity(1)}"); // Output: "1 car"
            Console.WriteLine($"Số nhiều: {"car".ToQuantity(3)}"); // Output: "3 cars"
            Console.WriteLine("\n=== Demo kết thúc ===");

            //12. Chuyển đổi số sang số la mã
            Console.WriteLine("\n--- Romanize ---");
            int romanNumber = 42;
            Console.WriteLine($"Romanize: {romanNumber} => {romanNumber.ToRoman()}"); // Output: "XLII"
            //13. Danh sách mảng
            var fruits = new[] { "apple", "banana", "cherry" };
            Console.WriteLine($"Danh sách trái cây: {string.Join(", ", fruits.Select(f => f.Humanize()))}");
        }
          
        enum MyEnum
        {
            MyValue,
            MySecondValue
        }
        static string DecimalToWords(decimal number)
        {
            // Chuyển đổi số thập phân thành chữ
            var wholePart = (int)number;
            var fractionalPart = (int)((number - wholePart) * 100);
            return $"{wholePart.ToWords()} point {fractionalPart.ToWords()}";
        }
    }
}
