using DataContracts;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ObjectRecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            return new List<Recipe>
            {
                new Recipe { Id = Guid.NewGuid(), Title = "Object Recipe 1" },
                new Recipe { Id = Guid.NewGuid(), Title = "Object Recipe 2" },
                new Recipe { Id = Guid.NewGuid(), Title = "Object Recipe 3" }
            };
        }
    }
}
