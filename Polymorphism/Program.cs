namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ------------------- Method Overloading -------------------");
            var math = new MathOperations();
            Console.WriteLine("Add(int a, int b) =>> " + math.Add(2, 2));
            Console.WriteLine("Add(double a, double b) =>> " + math.Add(2.4, 2.8));
            Console.WriteLine("Add(int a, int b, int c) =>> " + math.Add(2,2,2));

            Console.WriteLine(" ------------------- Operator Overloading -------------------");
            var c1 = new Complex(8.0, 6.0);
            var c2 = new Complex(4.0, 3.0);
            var add = c1 + c2;
            Console.WriteLine("add operator result =>> " + add.ToString());
            var sub = c1 - c2;
            Console.WriteLine("add operator result =>> " + sub.ToString());
            var mul = c1 * c2;
            Console.WriteLine("add operator result =>> " + mul.ToString());
            var div = c1 / c2;
            Console.WriteLine("add operator result =>> " + div.ToString());

            Console.WriteLine(" ------------------- Runtime PolyMorphism -------------------");

            Animal dog = new Dog();
            dog.Speaks();
            Animal cat = new Cat();
            cat.Speaks();

            Console.WriteLine(" ------------------- Runtime PolyMorphism Interface -------------------");

            var rectangleWithInterface = new RectangleWithInterface();
            rectangleWithInterface.Draw();

            var circleWithInterface = new CircleWithInterface();
            circleWithInterface.Draw();

            Console.WriteLine(" ------------------- Runtime PolyMorphism Abstract -------------------");

            var rectangleWithAbstract = new RectangleWithAbstract();
            rectangleWithAbstract.Draw();

            var circleWithAbstract = new CircleWithAbstract();
            circleWithAbstract.Draw();

            Console.WriteLine(" ------------------- PolyMorphism with Generics -------------------");

            Printer<int> PrinterCount = new Printer<int>();
            PrinterCount.Print(100);

            Printer<string> PrinterName = new Printer<string>();
            PrinterName.Print("HP Printer");
        }
    }


    // Compile-time Polymorphism (Method Overloading)
    #region Compile-time Polymorphism (Method Overloading)
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    #endregion

    // Compile-time Polymorphism (Operator Overloading)
    #region Compile-time Polymorphism (Operator Overloading)
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real, c1.Imaginary * c2.Imaginary);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(c1.Real / c2.Real, c1.Imaginary / c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
    #endregion

    // Runtime PolyMorphism
    #region Runtime PolyMorphism
    public class Animal
    {
        public virtual void Speaks()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speaks()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    public class Cat : Animal
    {
        public override void Speaks()
        {
            Console.WriteLine("Cat Meows");
        }
    }
    #endregion


    // Runtime PolyMorphism with Interface
    #region Runtime PolyMorphism Interface
    public interface Ishape
    {
        void Draw();
    }

    public class RectangleWithInterface : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Draw rectangle with Interface");
        }
    }

    public class CircleWithInterface : Ishape
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle with Interface");
        }
    }
    #endregion


    // Runtime PolyMorphism with Abstract
    #region Runtime PolyMorphism Abstract
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class RectangleWithAbstract : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle with Abstract");
        }
    }

    public class CircleWithAbstract : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle Abstract");
        }
    }
    #endregion

    // Polymorphism with Generics
    #region Polymorphism with Generics
    public class Printer<T>
    {
        public void Print(T Value)
        { 
            Console.WriteLine(Value);
        }
    }

    #endregion
}
