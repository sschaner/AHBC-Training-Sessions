using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public interface ICollection
    {
        // declaring Collection with IEnumerable so they can use any type of collection (List, Array, ArrayList, etc.) IEnumerable is a collection you can loop through
        IEnumerable<ICollectable> Collection { get; set; }

        public void Add(ICollectable item);

        ICollectable GetItem();
    }
}
