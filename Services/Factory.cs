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

            Instance = Activator.CreateInstance(assemblyFileName, className).Unwrap() as AbstractRecipesServices;
        }

        public static AbstractRecipesServices? Instance { get; set; }
    }
}
