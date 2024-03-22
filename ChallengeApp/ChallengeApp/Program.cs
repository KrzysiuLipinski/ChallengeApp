using ChallengeApp;

var employee = new Employee("Krzysiu", "Lipiński");
employee.AddGrade("Krzysiu");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
