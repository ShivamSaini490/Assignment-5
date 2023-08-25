using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

partial class Person
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.FirstName = "Shivam";
        person.LastName = "Saini";

        person.PrintFullName();
    }
}
