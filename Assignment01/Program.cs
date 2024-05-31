using System;

class Pet
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }

    public Pet(string type, string name)
    {
        Type = type;
        Name = name;
        Hunger = 5;
        Happiness = 5;
        Health = 5;
    }

    public void Feed()
    {
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        Console.WriteLine($"{Name} is fed. Hunger decreases slightly. Health improves.");
    }

    public void Play()
    {
        Happiness = Math.Min(10, Happiness + 2);
        Hunger = Math.Max(0, Hunger + 1);
        Console.WriteLine($"{Name} is playing. Happiness increases. Hunger increases slightly.");
    }

    public void Rest()
    {
        Health = Math.Min(10, Health + 2);
        Happiness = Math.Max(0, Happiness - 1);
        Console.WriteLine($"{Name} is resting. Health improves. Happiness decreases slightly.");
    }

    public void StatusCheck()
    {
        if (Hunger <= 2)
            Console.WriteLine($"{Name} is very hungry. Please feed!");
        if (Happiness <= 2)
            Console.WriteLine($"{Name} is very unhappy. Please play!");
        if (Health <= 2)
            Console.WriteLine($"{Name} is very unhealthy. Please rest!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Virtual Pet Simulator!");

        Console.Write("Enter the type of pet (e.g., cat, dog, rabbit): ");
        string type = Console.ReadLine();

        Console.Write("Enter your pet's name: ");
        string name = Console.ReadLine();

        Pet pet = new Pet(type, name);

        Console.WriteLine($"Congratulations! You have a new {pet.Type} named {pet.Name}.");

        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Type 'feed' to feed your pet.");
        Console.WriteLine("2. Type 'play' to play with your pet.");
        Console.WriteLine("3. Type 'rest' to let your pet rest.");
        Console.WriteLine("4. Type 'status' to check your pet's status.");
        Console.WriteLine("5. Type 'exit' to quit the game.");

        while (true)
        {
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "feed":
                    pet.Feed();
                    break;
                case "play":
                    pet.Play();
                    break;
                case "rest":
                    pet.Rest();
                    break;
                case "status":
                    pet.StatusCheck();
                    break;
                case "exit":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}