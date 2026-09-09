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
            return this.GetAllRecipes("sSelectRecipes", System.Data.CommandType.StoredProcedure);
        }
    }
}
