using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class MultichoiceAnswerRepository
    {
        public IEnumerable<MultichoiceAnswer> GetListOfMultichoiceAnswers()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.MultichoiceAnswers.ToList();
            }
        }

        public void AddMultichoiceAnswers(MultichoiceAnswer multichoiseAnswer)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.MultichoiceAnswers.Add(multichoiseAnswer);
            }
        }

        public void DeleteAddMultichoiceAnswers(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                MultichoiceAnswer multichoiceAnswer = context.MultichoiceAnswers.Find(Id);
                context.MultichoiceAnswers.Remove(multichoiceAnswer);
            }
        }

        public MultichoiceAnswer GetMultichoiceAnswerById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.MultichoiceAnswers.Find(Id);
            }
        }
    }
}

