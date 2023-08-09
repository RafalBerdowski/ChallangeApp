using ChallangeApp;

Employee employee1 = new Employee("Ola", "Kmicic", 26);
Employee employee2 = new Employee("Max", "Manzo", 23);
Employee employee3 = new Employee("Asia", "Wist", 49);


employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(3);

employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(10);

employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(8);
employee3.AddScore(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (Employee employee in employees) 
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult =(Employee)employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik " + employeeWithMaxResult.Name + " " + "" + employeeWithMaxResult.Surname + ", " + "" + (employeeWithMaxResult.Age + " " + "lat, ") + "" + "uzyskal najlepszy wynik: " + "" + employeeWithMaxResult.Result + " pkt. ");



