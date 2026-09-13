using System;

namespace Task3_AreaCalculator {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("Площу якої фігури ви хочете отримати?");
                Console.WriteLine("1 - Квадрат");
                Console.WriteLine("2 - Круг");
                Console.WriteLine("3 - Прямокутник");
                Console.WriteLine("4 - Трикутник");
                Console.WriteLine("0 - Вийти з програми (або натисніть Enter)");
                Console.Write("Ваш вибір: ");

                string inputChoice = Console.ReadLine() ?? "";
                string choice = inputChoice.Trim().ToLower();

                // Вихід з програми
                if (string.IsNullOrWhiteSpace(choice) || choice == "0" || choice == "exit") {
                    break;
                }

                switch (choice) {
                    case "1":
                    case "квадрат": {
                        Console.Write("Введіть розмір сторони: ");
                        double side = ReadDouble();
                        double area = side * side;
                        Console.WriteLine($"-> Площа квадрата = {area}");
                        break;
                    }
                    case "2":
                    case "круг": {
                        Console.Write("Введіть радіус: ");
                        double radius = ReadDouble();
                        double area = Math.PI * radius * radius;
                        Console.WriteLine($"-> Площа круга = {area}");
                        break;
                    }
                    case "3":
                    case "прямокутник": {
                        Console.Write("Введіть довжину першої сторони: ");
                        double sideA = ReadDouble();
                        Console.Write("Введіть довжину другої сторони: ");
                        double sideB = ReadDouble();
                        double area = sideA * sideB;
                        Console.WriteLine($"-> Площа прямокутника = {area}");
                        break;
                    }
                    case "4":
                    case "трикутник": {
                        Console.Write("Введіть розмір основи: ");
                        double baseSide = ReadDouble();
                        Console.Write("Введіть висоту трикутника: ");
                        double height = ReadDouble();
                        double area = (baseSide * height) / 2.0;
                        Console.WriteLine($"-> Площа трикутника = {area}");
                        break;
                    }
                    default: {
                        Console.WriteLine("Невідома фігура! Спробуйте ще раз.");
                        break;
                    }
                }
            }
        }

        // Допоміжний метод для безпечного зчитування дробових чисел (підтримує і крапку, і кому)
        static double ReadDouble() {
            string input = Console.ReadLine() ?? "0";
            input = input.Replace(',', '.');
            double.TryParse(input, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double result);
            return result;
        }
    }
}