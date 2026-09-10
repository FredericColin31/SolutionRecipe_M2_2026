using DataContracts;
using Microsoft.EntityFrameworkCore;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Db04RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            using (var context = new DataAccessLayer.BRecipesContext())
            {
                return context.Recipes.Select(@recipe => new DataContracts.Recipe() { Id = @recipe.Id, Title = @recipe.Title }).ToList();
            }
        }

        public override List<Recipe> GetByTitle(string title)
        {
            using (var context = new DataAccessLayer.BRecipesContext())
            {
                return context.Recipes.Where(@recipe => @recipe.Title.Contains(title)).Select(@recipe => new DataContracts.Recipe() { Id = @recipe.Id, Title = @recipe.Title }).ToList();
            }
        }
    }
}
