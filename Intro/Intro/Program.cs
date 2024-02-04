using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

// variables --> camelCase
bool isAuthenticated = true;

Console.WriteLine(message1);

// condition

if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Alptekin");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"};
// string[] loans2 = new string[3];
// loans2[0] = "Kredi 1";

// loop
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " : " + courses[i].Description + " : " + courses[i].Price + " TL");
}