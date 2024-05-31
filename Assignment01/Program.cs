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
