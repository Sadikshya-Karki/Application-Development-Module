DateTime birthDate = new DateTime(2006, 2, 10);
DateTime currentDate = DateTime.Now;
DateTime newDate = birthDate.AddDays(10);

TimeSpan difference = currentDate - birthDate;
int age = (int)(difference.TotalDays / 365.2422);

Console.WriteLine($"Birthdate : {birthDate}");
Console.WriteLine($"Current date : {currentDate}");
Console.WriteLine($"Age in years : {age}");
Console.WriteLine($"After adding 10 days : {newDate}");