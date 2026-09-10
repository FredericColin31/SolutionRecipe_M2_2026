using DataContracts;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Services
{
    public class Xml2RecipesServices : AbstractRecipesServices
    {
        public override List<Recipe> GetAll()
        {
            var xdoc = new XDocument();

            xdoc = XDocument.Load("recipes.xml");

            return xdoc.Descendants("recipe").Select(node => new Recipe() { Id = Guid.Parse(node.Attribute("id")?.Value ?? Guid.Empty.ToString()), Title = node.Attribute("title")?.Value ?? string.Empty }).ToList();
        }

        public override List<Recipe> GetByTitle(string title)
        {
            return null;
        }
    }
}
