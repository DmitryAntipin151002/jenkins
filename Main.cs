using System;

class Program
{
    static void Main(string[] args)
    {
        // Устанавливаем время, когда нужно вывести информацию (в данном случае - в полночь)
        DateTime targetTime = DateTime.Today.AddDays(1); 
        TimeSpan timeToWait = targetTime - DateTime.Now;

        
        System.Threading.Timer timer = new System.Threading.Timer(callback =>
        {
            // Выводим Фамилию, Имя и текущую дату
            string lastName = "Антипин";
            string firstName = "Дмитрий";
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"{lastName}, {firstName}, {currentDate}");

        }, null, timeToWait, TimeSpan.FromDays(1)); // Повторяем каждые 24 часа

        // Ждем, чтобы консольное приложение не закрылось сразу
        Console.ReadLine();
    }
}
