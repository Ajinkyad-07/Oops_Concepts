using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inheritance
{

    class A
    {
        public A()
        {
        }

        public virtual void method1()
        {
            Console.WriteLine("method1 - A");
            var abc = new Dictionary<int, string>() {
                        { 1, "one" },
                        { 2, "two" },
                        { 3, "three" },
                        { 4, "four" }
                    };
            abc.TryGetValue(1, out var str);
            Console.WriteLine(str);
        }
    }

    class B : A
    {
        public B()
        {
        }

        public override void method1()
        {
            Console.WriteLine("method11 - B");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
           a.method1();

            //// Single Inhertance
            //Console.WriteLine("------------- Single Inhertance -------------");
            //var dog = new Dog();
            //dog.Bark();
            //dog.Eat();

            //// Multilevel Inhertance
            //Console.WriteLine("------------- Multilevel Inhertance -------------");
            //var dog1 = new Dog1();
            //dog1.Bark();
            //dog1.Eat();
            //dog1.Walk();

            //// Hierarchical Inhertance
            //Console.WriteLine("------------- Multilevel Inhertance -------------");
            //var cat = new Cat();
            //cat.Eat();
            //cat.Meow();

            //var cow = new Cow();
            //cow.Eat();
            //cow.Milk();

            //// Hybrid Inhertance
            //Console.WriteLine("------------- Hybrid Inhertance -------------");
            //var horse = new Horse();
            //horse.Eat();
            //horse.Play();
            //horse.Runs();

            //// Multiple Inhertance
            //Console.WriteLine("------------- Multiple Inhertance -------------");
            //var huskey = new Huskey();
            //huskey.Eat(); 
            //huskey.Play();

        }
    }
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    // Single inheritance
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }


    // Multilevel
    public class Mamle : Animal
    {
        public void Walk()
        {
            Console.WriteLine("The mamale walks.");
        }
    }

    public class Dog1 : Mamle
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }


    // Hirarchical

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    public class Cow : Animal
    {
        public void Milk()
        {
            Console.WriteLine("This cow gives milk.");
        }
    }

    // Hybrid Inheritance 
    public interface IPet
    {
        void Play();
    }
    public class Horse : Animal, IPet
    {
        public void Play()
        {
            Console.WriteLine("The horse plays.");
        }
        public void Runs()
        {
            Console.WriteLine("The horse runs.");
        }
    }

    // Multiple Inheritance 
    public interface IAnimal
    {
        void Eat();
    }
    public interface IPet1
    {
        void Play();
    }

    public class Huskey : IAnimal, IPet1
    {
        public void Eat()
        {
            Console.WriteLine("Huskey Eats");
        }

        public void Play()
        {
            Console.WriteLine("Huskey Plays");
        }
    }

}
