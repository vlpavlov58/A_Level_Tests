using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class QuestionTypeRepository
    {
        public IEnumerable<QuestionType> GetListOfQuestionTypes()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.QuestionTypes.ToList();
            }
        }

        public void AddQuestionType(QuestionType questiontype)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.QuestionTypes.Add(questiontype);
            }
        }

        public void DeleteQuestionType(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                QuestionType questiontype = context.QuestionTypes.Find(Id);
                context.QuestionTypes.Remove(questiontype);
            }
        }

        public QuestionType GetQuestionTypeById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.QuestionTypes.Find(Id);
            }
        }
    }
}
