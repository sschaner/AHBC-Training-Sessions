using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public class CoralCollection : ICollection
    {
        public IEnumerable<ICollectable> Collection { get; set; }

        public void Add(ICollectable item)
        {
            // 
        }

        public ICollectable GetItem()
        {
            return new Coral();
        }
    }
}
