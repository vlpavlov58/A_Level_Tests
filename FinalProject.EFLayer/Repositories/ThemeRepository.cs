﻿using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class ThemeRepository
    {
        public IEnumerable<Theme> GetListOfTheme()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Themes.ToList();
            }
        }

        public void AddTheme(Theme theme)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Themes.Add(theme);
            }
        }

        public void DeleteTheme(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Theme theme = context.Themes.Find(Id);
                context.Themes.Remove(theme);
            }
        }

        public Theme GetThemeById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Themes.Find(Id);
            }
        }
    }
}
