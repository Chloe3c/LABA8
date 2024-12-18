using System.Globalization;

Console.WriteLine("Введите первое время (часы:минуты, например, 14:30): ");
TimeSpan firstTime = TimeSpan.Parse(Console.ReadLine());
Console.WriteLine("Введите второе время (часы:минуты, например, 18:45): ");
TimeSpan secondTime = TimeSpan.Parse(Console.ReadLine());
TimeSpan difference = secondTime - firstTime;
if (difference < TimeSpan.Zero)
{
 difference += TimeSpan.FromDays(1);
}

Console.WriteLine($"Количество часов между введенными временами: {difference.TotalHours} часов");
Console.WriteLine();



 
        Console.WriteLine("Введите дату в формате ДД.ММ.ГГГГ (например, 15.03.2023): ");
        string inputDate = Console.ReadLine();

try
{
    DateTime date = DateTime.ParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
    string monthName = date.ToString("MMMM", CultureInfo.GetCultureInfo("ru-RU")); 
    int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month); 

    Console.WriteLine($"Месяц: {monthName}");
    Console.WriteLine($"Количество дней в месяце: {daysInMonth}");
}
catch (FormatException)
{
            Console.WriteLine("Неверный формат даты. Пожалуйста, используйте формат ДД.ММ.ГГГГ.");
        }
   
