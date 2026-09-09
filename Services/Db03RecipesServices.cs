using DataContracts;
using Services.Core;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Services
{
    public class Db03RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            var invariantName = "System.Data.SqlClient";

            DbProviderFactories.RegisterFactory(invariantName, System.Data.SqlClient.SqlClientFactory.Instance);

            var factory = DbProviderFactories.GetFactory(invariantName);

            using (var connection = factory.CreateConnection())
            {
                connection.ConnectionString = "RecipesConnectionString".GetConnectionStringFor();
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Id, Title FROM Recipes";
                    using (var reader = command.ExecuteReader())
                    {
                        var recipes = new List<Recipe>();
                        while (reader.Read())
                        {
                            var recipe = new Recipe
                            {
                                Id = reader.GetGuid(0),
                                Title = reader.GetString(1)
                            };
                            recipes.Add(recipe);
                        }
                        return recipes;
                    }
                }
            }
        }
    }
}
