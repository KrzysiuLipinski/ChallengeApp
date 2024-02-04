string name = "Krzysiu";
int age = 20;
bool man = true;

if (man && age < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (man && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (!man && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (!man && age == 30)
{
    Console.WriteLine("Ewa lat 30");
}