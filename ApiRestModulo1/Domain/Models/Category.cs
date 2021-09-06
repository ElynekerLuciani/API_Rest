using System.Collections.Generic;

namespace ApiRestModulo1.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; }

    }
}
