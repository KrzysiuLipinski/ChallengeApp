﻿namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
     
        public string Name { get; private set; }
     
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }

        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}