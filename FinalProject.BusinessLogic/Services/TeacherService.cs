using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;


namespace FinalProject.BusinessLogic.Services
{

    public interface ITeacherService
    {
        List<TeacherDto> GetTeacherList();
    }
    internal class TeacherService : ITeacherService
    {
        public List<TeacherDto> GetTeacherList()
        {
            var teacherRepository = new TeacherRepository();

            var teacherList = teacherRepository.GetListOfTeachers();

            return teacherList.Select(x => x.ToTeacherDto()).ToList();
        }
    }
}
