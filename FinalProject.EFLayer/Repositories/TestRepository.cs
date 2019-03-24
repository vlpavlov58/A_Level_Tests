using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class TestRepository
    {
        public IEnumerable<Test> GetListOfTest()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Tests.ToList();
            }
        }

        public void AddTest(Test test)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Tests.Add(test);
            }
        }

        public void DeleteTest(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Test test = context.Tests.Find(Id);
                context.Tests.Remove(test);
            }
        }

        public Test GetTestById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Tests.Find(Id);
            }
        }
    }
}
