using conceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee e1 = new SalaryEmployee()
{
    id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990,5,23),
    HiringDate = new Date(2022,1,15),
    IsActive = true,   
    Salary = 1845453.45M
};
Console.WriteLine(e1);
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
Console.WriteLine(e2);

