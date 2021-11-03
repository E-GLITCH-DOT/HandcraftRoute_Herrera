using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Municipality
    {
        public Municipality()
        {
            CraftTourMatrialCraftNavigations = new HashSet<CraftTour>();
            CraftTourVisitPoint1Navigations = new HashSet<CraftTour>();
            CraftTourVisitPoint3Navigations = new HashSet<CraftTour>();
            CraftTourVisitPoint2Navigations = new HashSet<CraftTour>();
            Craftmen = new HashSet<Craftman>();
        }

        public int IdMunicipality { get; set; }
        public string NameMunicp { get; set; }

        public virtual ICollection<CraftTour> CraftTourMatrialCraftNavigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPoint1Navigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPoint3Navigations { get; set; }
        public virtual ICollection<CraftTour> CraftTourVisitPoint2Navigations { get; set; }
        public virtual ICollection<Craftman> Craftmen { get; set; }
    }
}
