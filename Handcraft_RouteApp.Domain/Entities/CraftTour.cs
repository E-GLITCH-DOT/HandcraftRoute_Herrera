using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class CraftTour
    {
        public int Id { get; set; }
        public string NameCTour { get; set; }
        public string DescriptionCTour { get; set; }
        public string MeetingPoint { get; set; }
        public int? VisitPoint1 { get; set; }
        public int? VisitPoint2 { get; set; }
        public int? VisitPoint3 { get; set; }
        public int? MatrialCraft { get; set; }

        public virtual Municipality MatrialCraftNavigation { get; set; }
        public virtual Municipality VisitPoint1Navigation { get; set; }
        public virtual Municipality VisitPoint3Navigation { get; set; }
        public virtual Municipality VisitPoint2Navigation { get; set; }
    }
}
