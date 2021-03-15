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
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId  );//bu mu projen evet
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success ==true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.BrandId + " / " + rental.BrandId);
                }
            }
            else
            {
                Console.WriteLine(result.Message );
            }
            
        }
    }
}

