using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public class Coral : ICollectable
    {
        // First 3 props are from ICollectable
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public double Weight { get; set; }
    }
}
