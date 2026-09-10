using DataContracts;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Xml1RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            var xmlDoc = new System.Xml.XmlDocument();

            xmlDoc.Load("recipes.xml");

            var recipes = new List<Recipe>();

            foreach (System.Xml.XmlNode recipeNode in xmlDoc.SelectNodes("/recipes/recipe"))
            {
                var recipe = new Recipe
                {
                    Id = Guid.Parse(recipeNode.Attributes["id"].Value),
                    Title = recipeNode.Attributes["title"].Value
                };
                recipes.Add(recipe);
            }

            return recipes;
        }

        public override List<Recipe> GetByTitle(string title)
        {
            return GetAll().Where(@recipe => recipe.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
