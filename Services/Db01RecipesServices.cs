using DataContracts;
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
            using (var connection = new SqlConnection("Data source=localhost;Initial catalog=bRecipes;User id=sa;Password=Formation@31;Encrypt=True;TrustServerCertificate=True;"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Title FROM Recipes";
                command.CommandType = System.Data.CommandType.Text;

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
