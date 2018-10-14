using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishContent.Classes
{
    class DeliveryGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PublishedName { get; set; }
        public Guid UUID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
