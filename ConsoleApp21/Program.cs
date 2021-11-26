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
            IStudentService service = new StudentService();
            //Student student = new Student() {FirstName = "Asadbek", LastName = "Ashirov", Age = 20, Phone = "+998906771565" };
            //service.Delete(2);
            foreach (var item in service.GetAll(p => !(p.Age > 20)))
            {
                Console.WriteLine(item.Id + "\t" + item.FirstName + " \t" + item.Age);
            }
            //var student = service.Get(3);
            //Console.WriteLine(student.FirstName);
        }
    }
}
