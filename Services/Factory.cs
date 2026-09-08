using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class Factory
    {
        static Factory()
        {
            Instance = new ObjectRecipesServices();
        }

        public static AbstractRecipesServices? Instance { get; set; }
    }
}
