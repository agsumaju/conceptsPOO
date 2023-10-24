using conceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");


Employee e1 = new SalaryEmployee()
{
    id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1845453.45M
};
//Console.WriteLine(e1);
Employee e2 = new ComissionByEmployee()
{
    id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sale = 320000000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(e2);

Employee e3 = new HourByEmployee()
{
    id = 3030,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1955, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
};
//Console.WriteLine(e3);
Employee e4 = new BaseCommisionEmployee()
{
    id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1988, 5, 23),
    HiringDate = new Date(2021, 2, 5),
    IsActive = true,
    Base = 860678.45M,
    Sale = 58000000M,
    CommissionPercentaje = 0.015F
};
//Console.WriteLine(e4);

ICollection<Employee> employees = new List<Employee>()
{
    e1,e2,e3,e4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                             ===================");
Console.WriteLine($"TOTAL                            {$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Description = "IPhone 3",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premiun",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);