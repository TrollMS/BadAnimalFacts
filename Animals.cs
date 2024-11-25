using System;

class Animal {

    public string Name { get; set;}

    public Animal(string name) {
        Name = name;
    }

    public virtual void PrintInfo() {
        Console.WriteLine($"Here is some cool facts about {Name}s \n");
    }

    public static void EndMessege() {
        Console.WriteLine("Any other animal you want to know cool facts on? Type list to see whats avalible or exit to quit\n");
    }
}

class Cat : Animal {
    public Cat(string name) : base(name) {}

    public override void PrintInfo() {
        base.PrintInfo();
        Console.WriteLine($"{Name}'s are cool \n");
        EndMessege();
    }
}

class Dog : Animal {
    public Dog(string name) : base(name) {}

    public override void PrintInfo()  {
        base.PrintInfo();
        Console.WriteLine($"{Name}s are cool but not as cool as Cats \n");
        EndMessege();
    }
}

class Rat : Animal {
    public Rat(string name) : base(name) {}

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"{Name}s are very sneaky creatures with cool small hands, they are known to be great cooks. \n");
        EndMessege();
    }
}