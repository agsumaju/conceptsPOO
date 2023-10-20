
using conceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");


try
{
	Console.WriteLine(new Date(2022, 12, 7));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(2023, 10, 02));
	Console.WriteLine(new Date(2017, 07, 31));
}
catch (Exception error)
{
	Console.WriteLine(error.Message);
}
