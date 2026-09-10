using DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesContracts
{
    public abstract class AbstractRecipesServices
    {
        public abstract List<Recipe> GetAll();
        public abstract List<Recipe> GetByTitle(string title);
    }
}
