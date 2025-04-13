public class Program
{
    public static void Main (string[] args)
    {
        string type, name, id;
        double wage;

        Console.WriteLine("Choose the new employee type:");
        Console.WriteLine("1. Permanent");
        Console.WriteLine("2. Contract");
        Console.WriteLine("3. Intern");

        Console.Write("Type: ");
        type = Console.ReadLine();

        Console.Write("Name: ");
        name = Console.ReadLine();

        Console.Write("ID  : ");
        id = Console.ReadLine();

        Console.Write("Wage: ");
        wage = double.Parse(Console.ReadLine());

        Console.WriteLine();

        switch (type)
        {
            case "1":
                EPermanent ePermanent = new EPermanent(name, id, wage);

                Console.WriteLine("New Permanent Employee");
                Console.WriteLine($"Name: {ePermanent.Name}");
                Console.WriteLine($"ID  : {ePermanent.Id}");
                Console.WriteLine($"Wage: {ePermanent.Wage}");
                break;
            case "2":
                EContract eContract = new EContract(name, id, wage);
                
                Console.WriteLine("New Permanent Employee");
                Console.WriteLine($"Name: {eContract.Name}");
                Console.WriteLine($"ID  : {eContract.Id}");
                Console.WriteLine($"Wage: {eContract.Wage}");
                break;
            case "3":
                EIntern eIntern = new EIntern(name, id, wage);
                
                Console.WriteLine("New Permanent Employee");
                Console.WriteLine($"Name: {eIntern.Name}");
                Console.WriteLine($"ID  : {eIntern.Id}");
                Console.WriteLine($"Wage: {eIntern.Wage}");
                break;
            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}

public class Employee
{
    private string id;
    private string name;
    private double wage;

    public Employee(string name, string id, double wage)
    {
        this.name = name;
        this.id = id;
        this.wage = wage;
    }

    public string Name { get { return name; } set { this.name = value; } }
    public string Id { get { return id; } set { this.id = value; } }
    public double Wage { get { return wage; } set { this.wage = value; } }

    public virtual void CalculateWage() { }
}

public class EPermanent : Employee
{
    private double contract_fee = 200000;

    public EPermanent(string name, string id, double wage) : base(name, id, wage)
    {

    }

    public override void CalculateWage()
    {
        Wage = Wage - contract_fee;
    }
}

public class EContract : Employee
{
    private double bonus = 500000;

    public EContract (string name, string id, double wage) : base(name, id, wage)
    {

    }

    public override void CalculateWage()
    {
        Wage = Wage + bonus;
    }
}

public class EIntern : Employee
{
    public EIntern(string name, string id, double wage) : base(name, id, wage)
    {

    }

    public override void CalculateWage()
    {
        Wage = Wage;
    }
}