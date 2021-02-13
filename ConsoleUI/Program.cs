using Business.Concrete;
using DataAccsess.Concrete.EntityFramework;
using DataAccsess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             CarTest();
           // ColorTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId  );
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success ==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.ModelName + " / " + car.CarId);
                }
            }
            else
            {
                Console.WriteLine(result.Message );
            }
            
        }
    }
}

