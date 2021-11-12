using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public class ComicFigurine : ICollectable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
