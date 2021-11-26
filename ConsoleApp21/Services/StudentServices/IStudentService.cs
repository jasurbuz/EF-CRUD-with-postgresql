using ConsoleApp21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Services.StudentServices
{
    interface IStudentService
    {
        public void Add(Student student);
        public IEnumerable<Student> GetAll(Expression<Func<Student, bool>> expression = null);
        public Student Get(int id);
        public void Update(int id, Student student);
        public void Delete(int id);
    }
}
