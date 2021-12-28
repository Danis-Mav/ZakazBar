using System;
using ZakazBar;

namespace ConsoleAppZakaz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command.Trim().ToLower() == "exit")
                    return;
                Execute(command);
            }
        }
        private static void Execute(string command)
        {
            var arguments = command.Trim().Split();
            switch (arguments[0])
            {
                case "add":
                    Add(arguments);
                    break;
                case "get":
                    Get(arguments);
                    break;
                case "update":
                    Update(arguments);
                    break;
                case "remove":
                    Remove(arguments);
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }

        }
        private static void Add(string[] args)
        {
            switch (args[1])
            {
                case "alk":
                    DataAccess.AddNewALKO
                    (
                             new ALKO
                            {
                                Id_alko = int.Parse(args[2]),
                                Name = args[3],
                                Price = int.Parse(args[4])
                            }
                    );
                    break;
                case "Employee":
                    DataAccess.AddNewEmployee
                    (
                        new Employee()
                        {
                            Name = args[2],
                            age = int.Parse(args[3]),
                            id_position = int.Parse(args[4])
                        }
                    );
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }
        private static void Get(string[] args)
        {
            switch (args[1])
            {
                case "alk":
                    foreach (var a in DataAccess.GetALKO())
                        Console.WriteLine($"{a.Id_alko} {a.Name}");
                    break;
                case "Employee":
                    foreach (var a in DataAccess.GetEmployee())
                        Console.WriteLine($"{a.ID} {a.Name}");
                    break;
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
        }
        private static void Remove(string[] args)
        {
            switch (args[1])
            {
                case "alk":
                   DataAccess.DeleteALKO(int.Parse(args[2]));
                    break;
                case "emloyee":
                    DataAccess.DeleteEmployee(int.Parse(args[2]));
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }
        private static void Update(string[] args)
        {
            switch (args[1])
            {
                case "animal":
                    DataAccess.UpdateEmployee(int.Parse(args[2]), new Employee() { Name = args[3] });
                    break;
            }
        }

    }
}