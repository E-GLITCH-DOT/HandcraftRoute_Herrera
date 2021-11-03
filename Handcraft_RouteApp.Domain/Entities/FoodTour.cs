using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class FoodTour
    {
        public int IdFoodTour { get; set; }
        public string NameFTour { get; set; }
        public string DescriptionFTour { get; set; }
        public string MeetingPoint { get; set; }
        public string FinalPoint { get; set; }
        public int NameComerce1 { get; set; }
        public int NameComerce2 { get; set; }
        public int? NameComerce3 { get; set; }
        public string MenuDescription { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public virtual Commerce NameComerce1Navigation { get; set; }
        public virtual Commerce NameComerce3Navigation { get; set; }
        public virtual Commerce NameComerce2Navigation { get; set; }
    }
}
