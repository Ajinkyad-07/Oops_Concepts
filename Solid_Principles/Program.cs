using static Solid_Principles.Robot;

namespace Solid_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Logger logger = new Logger();
            logger.PrintLogs("test solid principle");

            // Leskov Subsitution Principle, It means sub class should be replacable with parent class without affecting the code.
            // It ensures that subclass needs to behave in a way that it doesnt break the functionality of parent class
            // So in below example, discount can be vary as per festival and seasons. So discount price can be different and there is another clasues for that discount
            // but the Calculate method structure remains same it will take input price and will return discounted price in double. But logic can be vary
            // hence In Discount class we marked calculate method as a abstract we are overriding that method in derived class.
            // So when we create instance of FestivalDiscount class by keeping Discount as a base type, it will work properly.
            // So assigning an instance of FestivalDiscount to a reference of type Discount, it will replace the functionality of parent class without any error

            Discount festiveDiscount = new FestivalDiscount(); // Leskov
            var festiveDiscountPrice = festiveDiscount.Calculate(100); // Open/Close
            logger.PrintLogs("festiveDiscountPrice is " + festiveDiscountPrice); // Single Responsibilty

            Discount seasonalDiscount = new SeasonlDiscount();
            var seasonDiscountPrice = seasonalDiscount.Calculate(100);
            logger.PrintLogs("seasonDiscountPrice is " + seasonDiscountPrice);


            logger.PrintLogs("----------------------------------------------------------------");

            var robot = new Robot();
            robot.Work();

            var human = new Human();
            human.Work();
            human.Eat();




            IMessageService messageService = new MessageService();
            Notification notification = new Notification(messageService);

            notification.Notify();

        }
    }

    // In single responsiblity priniciple a class should have only one job or responsibility. 
    // In below class Discount has functionality to Calculate and Print Discount 
    // And logger class has only Loggin functionaluty and Hence is uses Single Responsibility principle

    public class Logger
    {
        public void PrintLogs(string log)
        {
            Console.WriteLine(log);
        }
    }

    public abstract class Discount
    {
        public abstract double Calculate(double price);

        public void PrintDiscountedPrice(double discountedPrice)
        {
            Console.WriteLine("discountedPrice", discountedPrice);
        }
    }

    // Open Close Principle, It is open for extension and closed for modification, It can be achieved using abstraction as mentioned in below code
    // In below code we have override Calculate method in derived to class to calculate discount as per there convienience.
    // Hence it is open for extension and close for modification.

    public class FestivalDiscount: Discount 
    {
        // Let's say we will give 50% discount
        public override double Calculate(double price)
        {
            return price * 0.5;
        }
    }

    public class SeasonlDiscount : Discount
    {
        // Let's say we will give 20% discount
        public override double Calculate(double price)
        {
            return price * 0.2;
        }
    }

    // Interface Segregation Principle, A class should not be forced to implement method it does not use.
    // So when we inherit interfaces so we must need to implement the methods and class as defined in the interface
    // If Each Interface should have specific defination which perform Single Responsibility. 
    // In there is a defination which is not needed in specific class but it will force us to implement it.
    // So to void this create sepereate small interfaces
    // 

    public interface IWorker
    {
        void Work();
    }
    public interface IHumanWorker : IWorker
    {
        void Eat();
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            {
                Console.WriteLine("Robot works");
            }
        }

        public class Human : IHumanWorker
        {
            public void Work()
            {
                Console.WriteLine("Human works");
            }
            public void Eat()
            {
                Console.WriteLine("Human eats");
            }
        }




        // Dependency Inversion Principle, High Level module and Low level module should not depend on each other but it should depend on abstraction
        // It makes the code loosely coupled and easier to test or replace dependencies.

        public interface IMessageService
        {
            void SendMessage();
        }

        public class MessageService : IMessageService
        {
            public void SendMessage()
            {
                Console.WriteLine("Message Sends successfully");
            }
        }

        public class Notification
        {
            private readonly IMessageService _messageService;

            public Notification(IMessageService messageService)
            {
                _messageService = messageService;
            }

            public void Notify()
            {
                _messageService.SendMessage();
            }
        }
    }


}
