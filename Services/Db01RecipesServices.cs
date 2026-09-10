using DataContracts;
using Services.Core;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Services
{
    public class Db01RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            return this.GetAllRecipes("SELECT Id, Title FROM Recipes", System.Data.CommandType.Text);
        }

        public override List<Recipe> GetByTitle(string title)
        {
            return null;
        }
    }
}
