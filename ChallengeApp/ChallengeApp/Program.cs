using ChallengeApp;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Krzysztof", "Kowalski", 20);
        Employee employee2 = new Employee("Joanna", "Kowalska", 30);
        Employee employee3 = new Employee("Krystian", "Kowalski", 40);

        List<Employee> employees = new List<Employee>()
        {
            employee1, employee2, employee3
        };

        // Dodanie ocen dla pracowników
        employee1.AddScore(9);
        employee1.AddScore(3);
        employee1.AddScore(4);
        employee1.AddScore(6);
        employee1.AddScore(2);

        employee2.AddScore(2);
        employee2.AddScore(4);
        employee2.AddScore(2);
        employee2.AddScore(5);
        employee2.AddScore(7);

        employee3.AddScore(4);
        employee3.AddScore(5);
        employee3.AddScore(8);
        employee3.AddScore(1);
        employee3.AddScore(8);

        // Znalezienie pracownika z największą liczbą punktów
        Employee employeeWithMaxResult = null;
        int maxResult = -1;
        foreach (var employee in employees)
        {
            if (employee.Result > maxResult)
            {
                maxResult = employee.Result;
                employeeWithMaxResult = employee;
            }
        }

        // Wyświetlenie informacji o pracowniku z największą liczbą punktów
        Console.WriteLine($"Pracownik z maksymalna liczba punktów:");
        Console.WriteLine($"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} {employeeWithMaxResult.Age} lat(a) zdobył(a) {maxResult} punktów.");
    }
}
