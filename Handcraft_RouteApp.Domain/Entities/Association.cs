using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Association
    {
        public Association()
        {
            Craftmen = new HashSet<Craftman>();
        }

        public int IdAssociation { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Craftman> Craftmen { get; set; }
    }
}
