namespace _2_POO_Lheritage;

class Program
{
    static void Main(string[] args)
    {
        Human human = new Human("blue");
        Console.WriteLine($"A human with {human.GetColorOfEyes()} eyes");
        human.Eat();
        human.Move();

        Console.WriteLine();

        Monkey monkey = new Monkey("black");
        Console.WriteLine($"A monkey with {monkey.GetColorOfHairs()} hairs");
        monkey.Eat();
        monkey.Move();

        Console.WriteLine();

        Elephant elephant = new Elephant("grey");
        Console.WriteLine($"A {elephant.GetColor()} elephant");
        elephant.Eat();
        elephant.Move();

        Console.WriteLine();

        Tortoise tortoise = new Tortoise ("green");
        Console.WriteLine($"A {tortoise.GetColor()} tortoise");
        tortoise.Eat();
        tortoise.Move();

        Console.WriteLine();

        Lizard lizard = new Lizard("beige");
        Console.WriteLine($"A {lizard.GetColor()} lizard");
        tortoise.Eat();
        tortoise.Move();

    }
}

