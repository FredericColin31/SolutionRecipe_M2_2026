using DataContracts;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Services.Core
{
    public static class AbstractRecipesServicesExtensions
    {
        public static List<DataContracts.Recipe> GetAllRecipes(this AbstractRecipesServices rs, String commandText, System.Data.CommandType commandType)
        {
            using (var connection = new SqlConnection("RecipesConnectionString".GetConnectionStringFor()))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = commandText;
                command.CommandType = commandType;

                var reader = command.ExecuteReader();
                var recipes = new List<Recipe>();
                while (reader.Read())
                {
                    var recipe = new Recipe
                    {
                        Id = Guid.Parse(reader["id"].ToString()),
                        Title = reader["title"].ToString()
                    };

                    recipes.Add(recipe);
                }

                return recipes;
            }
        }
    }
}
