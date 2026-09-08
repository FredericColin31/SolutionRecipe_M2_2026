using Services.Core;
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
            var assemblyFileName = "AssemblyLongFormName".GetValueFor();
            var className = "ClassName".GetValueFor();

            Instance = new ObjectRecipesServices();
        }

        public static AbstractRecipesServices? Instance { get; set; }
    }
}
