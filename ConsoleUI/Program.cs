using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------CAR RENTAL----------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("Araç Markaları");

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("{0}-------{1}",brand.BrandId,brand.BrandName);

            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Araç Özellikleri ve Yılı");

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}-------{1}", car.Descriptions, car.ModelYear);
            }
        }
    }
}
