using DataContracts;
using Services.Core;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Services
{
    public class Db02RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            using (var connection = new SqlConnection("RecipesConnectionString".GetConnectionStringFor()))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "sSelectRecipes";
                command.CommandType = System.Data.CommandType.StoredProcedure;

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
