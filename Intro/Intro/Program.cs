using Intro.Business;
using Intro.DataAccess.Concrete;
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

CourseManager courseManager = new(new EFCourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " : " + courses[i].Description + " : " + courses[i].Price + " TL");
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345678922";
customer1.FirstName = "Alptekin";
customer1.LastName = "OCAKDAN";
customer1.NationalIdentity = "12345678910";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "12345678923";
customer2.FirstName = "Engin";
customer2.LastName = "Demiroğ";
customer2.NationalIdentity = "12345678911";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CustomerNumber = "12345678924";
customer3.CompanyName = "Kodlama.io";
customer3.TaxNumber = "12345678912";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CustomerNumber = "12345678925";
customer4.CompanyName = "AO Software";
customer4.TaxNumber = "12345678913";

// value types ---> int, decimal, float, double, bool
// reference types ---> array, class, interface


// Polymorphism
Customer[] customers = {customer1, customer2, customer3, customer4};

foreach (Customer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}