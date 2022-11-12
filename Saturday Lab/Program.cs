using Saturday_Lab;

var emp1 = new Employee
{
	Name = "Arjun",
	Department = "PES",
	Designation = "Trainee",
};

var emp2 = new Employee
{
	Name = "Anunath",
	Department = "EES",
	Designation = "Technical head",
};

var emp3 = new Employee
{
	Name = "Aadith",
	Department = "VVD",
	Designation = "Software head",
};


emp1.ForSalary();
emp2.ForSalary();
emp3.ForSalary();

//...............................................................................


//using Saturday_Lab;

var mob1 = new Mobile
{
	Name = "Realme3pro",
	Model = "3pro",
	Price = 14000

};
mob1.readData(mob1.Name, mob1.Model, mob1.Price);

var mob2 = new Mobile
{
	Name = "Realme4pro",
	Model = "4pro",
	Price = 15000,
	Company = "Realme"
};
mob2.readData(mob2.Name, mob2.Model, mob2.Price, mob2.Company);

mob2.readData(mob2.Name, mob2.Model, mob2.Price);

//................................................................................

//using Saturday_Lab;

var animals = new Animals();
Console.WriteLine($"Animal name : {animals.Name}");
Console.WriteLine($"Animal Lifetime : {animals.MaxLifetime} years");
Console.WriteLine($"Animal food : {animals.Food}");

//................................................................................

//using Saturday_Lab;

var furniture = new Furniture();
furniture.Wood = "Rosewood";

//................................................................................

for (int i = 1; i <= 50; i++)
{
	if (i % 3 == 0 && i % 5 == 0)
	{
		Console.WriteLine("fizzbuzz");
	}
	else if (i % 5 == 0)
	{
		Console.WriteLine("buzz");
	}
	else if (i % 3 == 0)
	{
		Console.WriteLine("fizz");
	}
	else
	{
		Console.WriteLine(i);
	}
}

//................................................................................

//using Saturday_Lab;

int opt;
var f = "y";
	var bank = new BankApp();


while (f == "y")
{

	Console.WriteLine("Bank Services");
	Console.WriteLine("Input the following numbers to get corresponding services");
	Console.WriteLine("1.Create Account \t 2.Deposit Cash \t 3.Withdraw cash \t 4.Balance Enquiry");
	opt = int.Parse(Console.ReadLine());


	switch (opt)
	{
		case 1:
			bank.Create();
			break;

		case 2:
			bank.Deposit();
			break;

		case 3:
			bank.Withdraw();
			break;

		case 4:
			bank.BalanceIn();
			break;

		default:
			break;
	}

	
	Console.WriteLine("Enter the option...Do you want to continue(y/n)?");
	f = Console.ReadLine();
	


}