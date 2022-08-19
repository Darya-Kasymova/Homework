Console.Write("Введи цифру, чтобы узнать, является ли этот день недели выходным: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("нет такого дня недели");
  }
  else Console.WriteLine("нет");
}

CheckingTheDayOfTheWeek(dayNumber);