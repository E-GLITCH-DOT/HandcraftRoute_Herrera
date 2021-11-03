using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class SocialNetwork
    {
        public SocialNetwork()
        {
            Craftmen = new HashSet<Craftman>();
        }

        public int IdSocialNetworks { get; set; }
        public string Link { get; set; }

        public virtual ICollection<Craftman> Craftmen { get; set; }
    }
}
