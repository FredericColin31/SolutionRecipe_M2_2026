using System;
using System.Collections.Generic;
using System.Text;

namespace DataContracts
{
    public class Recipe
    {
        public required Guid Id { get; set; }
        public required String Title { get; set; } = String.Empty;
    }
}
