// Homework day 4.

string name = "Rafal";
var age = 17;
bool women = false;

if (women && age < 30 == true)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (women && age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa lat 33");
}
else if (!women && age < 18 && name != "Ewa")
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}

