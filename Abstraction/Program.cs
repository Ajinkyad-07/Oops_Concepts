﻿namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Abstraction with Abstract Class--------------------");
            Animal dog = new Dog();
            dog.MakeSound();
            dog.Sleep();

            Animal cat = new Cat();
            cat.MakeSound();
            cat.Sleep();

            Console.WriteLine("--------------------Abstraction with Interfaces--------------------");

            IVehicle car = new Car();
            car.Start();
            car.Stop();

            IVehicle bike = new Bike();
            bike.Start();
            bike.Stop();

            Console.WriteLine("--------------------Abstraction in a Banking System (Abstract Class)--------------------");
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(10000);
            savingsAccount.Withdraw(4000);
            savingsAccount.GetBalance();
        }
    }

    #region Abstraction with Abstract Class
    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping...");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks...");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meow...");
        }
    }
    #endregion


    #region Abstraction with Interface
    public interface IVehicle
    {
        void Start();
        void Stop();
    }

    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Car is stopping.");
        }
    }

    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Bike is stopping.");
        }
    }

    #endregion

    #region Abstraction in a Banking System (Abstract Class)

    public abstract class Account
    {
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);

        public void ShowBalance(decimal balance)
        {
            Console.WriteLine($"Current balance: {balance:C}");
        }
    }

    public class SavingsAccount : Account
    {
        private decimal balance;

        public override void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C} to savings account.");
        }

        public override void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from savings account.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public void GetBalance()
        {
            ShowBalance(balance);
        }
    }

    #endregion
}
