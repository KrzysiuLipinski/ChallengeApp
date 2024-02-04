string imie = "Krzysiu";
int wiek = 20;
bool mezczyzna = true;

if (mezczyzna && wiek < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (mezczyzna && wiek > 30)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (!mezczyzna && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (!mezczyzna && wiek == 30)
{
    Console.WriteLine("Ewa lat 30");
}