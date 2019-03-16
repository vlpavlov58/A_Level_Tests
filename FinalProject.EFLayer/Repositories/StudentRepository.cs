using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class StudentRepository
    {
        public IEnumerable<Student> GetListOfStudents()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Students.ToList();
            }
        }

        public void AddStudent(Student student)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Students.Add(student);
            }
        }

        public void DeleteStudent(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Student student = context.Students.Find(Id);
                context.Students.Remove(student);
            }
        }

        public Student GetStudentById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Students.Find(Id);
            }
        }
    }
}
