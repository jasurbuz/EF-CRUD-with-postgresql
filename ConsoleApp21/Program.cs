using ConsoleApp21.DataLayer;
using ConsoleApp21.Models;
using ConsoleApp21.Services.StudentServices;
using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();
            Student student = new Student() { FirstName = "Azimjon", LastName = "Erkinov", Age = 19, Phone = "+998934630527" };
            service.Delete(2);
            foreach (var item in service.GetAll())
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
