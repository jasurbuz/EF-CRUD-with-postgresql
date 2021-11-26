using ConsoleApp21.DataLayer;
using ConsoleApp21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Services.StudentServices
{
    class StudentService : IStudentService
    {
        DBContext DB = new DBContext();
        public void Add(Student student)
        {
            DB.Students.Add(student);
            DB.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = DB.Students.FirstOrDefault(x => x.Id == id);
            if(student is not null)
                DB.Students.Remove(student);
            DB.SaveChanges();
        }

        public Student Get(int id)
        {
            Student student = DB.Students.FirstOrDefault(x => x.Id == id);
            return student;
        }

        public IEnumerable<Student> GetAll(Expression<Func<Student, bool>> expression = null)
        {
            if(expression is null)
                return DB.Students;
            return DB.Students.Where(expression);
        }

        public void Update(int id, Student student)
        {
            Student ustudent = DB.Students.FirstOrDefault(x => x.Id == id);
            ustudent.FirstName = student.FirstName;
            ustudent.LastName = student.LastName;
            ustudent.Age = student.Age;
            ustudent.Phone = student.Phone;
            DB.SaveChanges();
        }
    }
}
