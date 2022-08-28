// See https://aka.ms/new-console-template for more information
using Linq;

Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>
{
    new Employee{Name="Hariom"},
    new Employee{Name="Hariom"},
    new Employee{Name="Sam"}
};
var result  = employees.GroupBy(x => x.Name).Select(x=>x.Count());
var result1 = employees.GroupBy(x => x.Name).Select(x => x.FirstOrDefault());
foreach (int i in result) { Console.WriteLine(i);}   
Console.ReadKey();
