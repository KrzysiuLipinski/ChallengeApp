int numbers = 1463;

string numbersAsString = numbers.ToString();

char[] letters = numbersAsString.ToArray();

Console.WriteLine("Number: "); Console.WriteLine(letters);

int zero = 0;
int one = 0;
int two = 0;
int three = 0;
int four = 0;
int five = 0;
int six = 0;
int seven = 0;
int eight = 0;
int nine = 0;


foreach (char number in letters)
{
    if (number == '0')
    {
        zero++;
    }
    else if (number == '1')
    {
        one++;
    }
    else if (number == '2')
    {
        two++;
    }
    else if (number == '3')
    {
        three++;
    }
    else if (number == '4')
    {
        four++;
    }
    else if (number == '5')
    {
        five++;
    }
    else if (number == '6')
    {
        six++;
    }
    else if (number == '7')
    {
        seven++;
    }
    else if (number == '8')
    {
        eight++;
    }
    else if (number == '9')
    {
        nine++;
    }
}

Console.WriteLine("0 => " + zero);
Console.WriteLine("1 => " + one);
Console.WriteLine("2 => " + two);
Console.WriteLine("3 => " + three);
Console.WriteLine("4 => " + four);
Console.WriteLine("5 => " + five);
Console.WriteLine("6 => " + six);
Console.WriteLine("7 => " + seven);
Console.WriteLine("8 => " + eight);
Console.WriteLine("9 => " + nine);