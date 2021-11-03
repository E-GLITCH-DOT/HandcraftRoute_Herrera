using System;
using System.Collections.Generic;

#nullable disable

namespace Handcraft_RouteApp.Domain.Entities
{
    public partial class Commerce
    {
        public Commerce()
        {
            FoodTourNameComerce1Navigations = new HashSet<FoodTour>();
            FoodTourNameComerce3Navigations = new HashSet<FoodTour>();
            FoodTourNameComerce2Navigations = new HashSet<FoodTour>();
        }

        public int IdCommerce { get; set; }
        public string NameCommerce { get; set; }
        public string Telephone { get; set; }

        public virtual ICollection<FoodTour> FoodTourNameComerce1Navigations { get; set; }
        public virtual ICollection<FoodTour> FoodTourNameComerce3Navigations { get; set; }
        public virtual ICollection<FoodTour> FoodTourNameComerce2Navigations { get; set; }
    }
}
