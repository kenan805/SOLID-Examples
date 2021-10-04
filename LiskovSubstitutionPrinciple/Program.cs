using System;

namespace LiskovSubstitutionPrinciple
{

    //L - Liskov Substitution Principle

    public abstract class Car
    {
        public abstract void Drive();
    }

    public interface IElectricCar
    {
        void ElectricCar();
    }

    public interface IBenzineCar
    {
        void BenzineCar();
    }

    public class Tesla : Car, IElectricCar
    {
        public override void Drive()
        {
            Console.WriteLine("Tesla drive.");
        }

        public void ElectricCar()
        {
            Console.WriteLine("Tesla is an electric car.");
        }
    }

    public class BMW : Car, IBenzineCar
    {
        public void BenzineCar()
        {
            Console.WriteLine("The BMW drive on gasoline.");
        }

        public override void Drive()
        {
            Console.WriteLine("Bmw drive.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new BMW();
            Car tesla = new Tesla();

            CarMethod(bmw);
            CarMethod(tesla);

            
        }

        static void CarMethod(Car car)
        {
            car.Drive();
        }
    }
}
