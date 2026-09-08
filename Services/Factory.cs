using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class Factory
    {
        public static AbstractRecipesServices? Instance { get; set; }
    }
}
