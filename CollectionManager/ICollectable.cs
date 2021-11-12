using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionManager
{
    public interface ICollectable
    {
        string Name { get; set; }
        double Price { get; set; }
        string Description { get; set; }
    }
}
