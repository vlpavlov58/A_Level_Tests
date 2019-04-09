using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class QuestionRepository
    {

        public IEnumerable<Question> GetListOfQuestion()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Questions.ToList();
            }
        }

        public void AddQuestion(Question question)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Questions.Add(question);
            }
        }

        public void DeleteQuestion(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Question question = context.Questions.Find(Id);
                context.Questions.Remove(question);
            }
        }

        public Question GetQuestionById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Questions.Find(Id);
            }
        }
    }
}
