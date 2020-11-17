using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public class ProjectDetail
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string LandArea { get; set; }

        public string Facing { get; set; }

        public string NumberOfAppartments { get; set; }
        public string SizeOfUnits { get; set; }

        public string CarParking { get; set; }
        public string NumberOfFloors { get; set; }

        public Status CurrentStatus { get; set; }
        public string CoverImage { get; set; }
        public List<string> Images { get; set; }

    }

    public enum Status
    {
        Ongoing,
        Upcoming,
        Completed
    }
}
