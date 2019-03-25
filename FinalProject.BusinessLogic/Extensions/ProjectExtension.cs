using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ProjectExtension
    {


        public static ModuleDto ToModuleDto(this Module module)
        {

            if (module == null)
                return null;

            var moduleDto = new ModuleDto
            {
                QuantityLessons = module.QuantityLessons.Value,
                QuestionList = module.Questions.Select(x => ToQuestionDto(x)).ToList(),
                ThemeList = module.Themes.Select(x => ToThemeDto(x)).ToList()
            };

            return moduleDto;

        }

        public static ThemeDto ToThemeDto(this Theme theme)
        {
            if (theme == null)
                return null;

            var themeDto = new ThemeDto
            {
                Name = theme.Name,
                QuestionList = theme.Questions.Select(x => ToQuestionDto(x)).ToList()
            };

            return themeDto;
        }

        public static QuestionDto ToQuestionDto(this Question question)
        {
            if (question == null)
                return null;

            var questionDto = new QuestionDto
            {
                Text = question.Text,
                TextAnswersList = question.TextAnswers
                                                     .Select(x => ToTextAnswerDto(x))
                                                     .ToList(),
                MultichoiceAnswersList = question.MultichoiceAnswers
                                                     .Select(x => ToMultichoiceAnswerDto(x))
                                                     .ToList()
            };

            return questionDto;
        }

        public static QuestionTypeDto ToQuestionTypeDto(this QuestionType questionType)
        {
            if (questionType == null)
                return null;

            var questionTypeDto = new QuestionTypeDto
            {
                Type = questionType.Type,
                QuestionsList = questionType.Questions.Select(x => ToQuestionDto(x)).ToList()
            };

            return questionTypeDto;
        }

        public static TextAnswerDto ToTextAnswerDto(this TextAnswer textAnswer)
        {
            if (textAnswer == null)
                return null;

            var textAnswerDto = new TextAnswerDto
            {
                Textbox = textAnswer.Textbox,
                IsCorrect = textAnswer.IsCorrect.Value
            };

            return textAnswerDto;
        }


        public static MultichoiceAnswerDto ToMultichoiceAnswerDto (this MultichoiceAnswer multichoice)
        {
            if (multichoice == null)
                return null;

            var multichoiceDto = new MultichoiceAnswerDto
            {
                AnswerText = multichoice.AnswerText,
                IsCorrect = multichoice.IsCorrect.Value,
            };

            return multichoiceDto;
        }

        public static CourseDto ToCourseDto(this Course course)
        {
            if (course == null)
                return null;

            var courseDto = new CourseDto
            {
                Name = course.Name,
                GroupsList = course.Groups.Select(x => ToGroupDto(x)).ToList(),
                ModulesList = course.Modules.Select(x => ToModuleDto(x)).ToList(),
                TeachersList = course.Teachers.Select(x => ToTeacherDto(x)).ToList()
            };

            return courseDto;
        }

        public static GroupDto ToGroupDto(this Group group)
        {
            if (group == null)
                return null;

            var groupDto = new GroupDto
            {
                Name = group.Name,
                BeginingDate = group.BeginigDate.Value,
                StudentsList = group.Students.Select(x => ToStudentDto(x)).ToList(),
                TeachersList = group.Teachers.Select(x => ToTeacherDto(x)).ToList()
            };

            return groupDto;
        }

        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            if (teacher == null)
                return null;

            var teacherDto = new TeacherDto
            {
                TestPassingList = teacher.TestPassings.Select(x => ToTestPassingDto(x)).ToList(),
                CoursesList = teacher.Courses.Select(x => ToCourseDto(x)).ToList(),
                GroupsList = teacher.Groups.Select(x => ToGroupDto(x)).ToList()
            };

            return teacherDto;
        }

        public static StudentDto ToStudentDto(this Student student)
        {
            if (student == null)
                return null;

            var studentDto = new StudentDto
            {
                TestPassingList = student.TestPassings.Select(x => ToTestPassingDto(x)).ToList(),
                GroupsList = student.Groups.Select(x => ToGroupDto(x)).ToList()
            };

            return studentDto;
        }

        public static TestPassingDto ToTestPassingDto(this TestPassing testPassing)
        {
            if (testPassing == null)
                return null;

            var testPassingDto = new TestPassingDto
            {
                Date = testPassing.Date.Value
            };

            return testPassingDto;
        }

        public static UserDto ToUserDto(this User user)
        {
            if (user == null)
                return null;

            var userDto = new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Login = user.Login,
                Password = user.Password,
                AdminsList = user.Admins.Select(x => ToAdminDto(x)).ToList(),
                StudentsList = user.Students.Select(x => ToStudentDto(x)).ToList(),
                TeachersList = user.Teachers.Select(x => ToTeacherDto(x)).ToList()
            };

            return userDto;
        }

        public static AdminDto ToAdminDto(this Admin admin)
        {
            if (admin == null)
                return null;

            var adminDto = new AdminDto();

            return adminDto;
        }

        public static UserTypeDto ToUserTypeDto(this UserType userType)
        {
            if (userType == null)
                return null;

            var userTypeDto = new UserTypeDto
            {
                Name = userType.Name,
                UsersList = userType.Users.Select(x => ToUserDto(x)).ToList()
            };

            return userTypeDto;
        }

        public static TestDto ToTestDto(this Test test)
        {
            if (test == null)
                return null;

            var testDto = new TestDto
            {
                ModulesList = test.Modules.Select(x => ToModuleDto(x)).ToList(),
                QuestionsList = test.Questions.Select(x => ToQuestionDto(x)).ToList(),
                TestPassingsList = test.TestPassings.Select(x => ToTestPassingDto(x)).ToList()
            };

            return testDto;
        }
    }
}
