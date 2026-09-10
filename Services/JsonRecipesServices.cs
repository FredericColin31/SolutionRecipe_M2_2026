using DataContracts;
using Newtonsoft.Json;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class JsonRecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            return JsonConvert.DeserializeObject<List<Recipe>>(File.ReadAllText("recipes.json"));
        }

        public override List<Recipe> GetByTitle(string title)
        {
            return GetAll().Where(@recipe => recipe.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
