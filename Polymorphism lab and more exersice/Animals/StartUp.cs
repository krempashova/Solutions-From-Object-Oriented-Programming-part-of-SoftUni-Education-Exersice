using Animals;

namespace Animals;
public class StartUp
{
    static void Main(string[]args)
    {
        Animal cat = new Cat("Poko", "pauch");
        Animal dog = new Dog("Tara","kokali");
        Console.WriteLine(cat.ExplainSelf());
        Console.WriteLine(dog.ExplainSelf());
    }
}

