namespace ChallengeApp
{
    public class Employee
    {
        private List<int> scores = new List<int>();

        public Employee(string name)
        {
            name = name;
        }

        public Employee(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.scores.Sum();
            }
        }

        public string V1 { get; }
        public string V2 { get; }
        public string name { get; }
        public object Login { get; set; }

        public void AddScore(int score)
        {
            this.scores.Add(score);
        }
    }
}


