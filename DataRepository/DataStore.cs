using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public class DataStore:IDataStore
    {
        public  List<ProjectDetail> AllProjectDetails;

        public DataStore()
        {
            AllProjectDetails = new List<ProjectDetail>();
            AddData();
        }

        public void AddData()
        {

            //NEEDS ADIRA
            ProjectDetail b = new ProjectDetail();
            b.Name = "NEEDS ADIRA";
            b.CurrentStatus = Status.Ongoing;
            b.Address = "Plot# 3, Road# 3, Block# A,Section# 6, Mirpur, Dhaka";
            b.CarParking = "8";
            b.Facing = "North";
            b.LandArea = "3 Katha";
            b.NumberOfAppartments = "Ground + 9";
            b.NumberOfAppartments = "9";
            b.SizeOfUnits = "1760";
            b.CoverImage = "adira.jpg";
            b.Description = "An exclusive address like no other, where prestige meets sophistication.";
            AllProjectDetails.Add(b);
            //Darul Mumin
            ProjectDetail a = new ProjectDetail();
            a.Name = "NEEDS Darul Munim";
            a.Address = "353/6, South Paikpara, Jheelpar, Mirpur-1, Dhaka-1216";
            a.CurrentStatus = Status.Ongoing;
            a.CarParking = "24";
            a.Facing = "East";
            a.LandArea = "11 Katha";
            a.NumberOfAppartments = "36";
            a.SizeOfUnits = "1232 - 1430";
            a.NumberOfFloors = "Ground + 9";
            a.CoverImage = "munim.jpg";
            a.Description = "East Facing Corner Plot, Situated in a very prestigious residential area of the capital";
            AllProjectDetails.Add(a);

            
            // NEEDS LATIF GARDEN
            ProjectDetail c = new ProjectDetail();
            c.Name = "NEEDS LATIF GARDEN";
            c.LandArea = "0 Katha";
            c.Address = "House# 0, Road# 0, Section# 0, Gulsan, Dhaka.";
            c.SizeOfUnits = "720-1195";
            c.CarParking = "9";
            c.CoverImage = "latif.jpg";
            c.NumberOfFloors = "Ground + 7 ";
            c.Description = "An exclusive address like no other, where prestige meets sophistication.";
            c.CurrentStatus = Status.Completed;
            AllProjectDetails.Add(c);

            //NEEDS SWAPNIL
            ProjectDetail d = new ProjectDetail();
            d.Name = "NEEDS Swapnil";
            d.CoverImage = "swapnil.jpg";
            d.Description = "An exclusive address like no other, where prestige meets sophistication.";
            d.LandArea = "8 Kathas";
            d.Address = "14/2, Al Modina Road, Ahmed Nagar, Mirpur-1, Dhaka-1216.";
            d.CarParking = "13";
            d.NumberOfAppartments = "24";
            d.CurrentStatus = Status.Completed;
            d.NumberOfFloors = "Ground + 8";
            d.SizeOfUnits = "975-1225";
            AllProjectDetails.Add(d);

            //Needs Palace
            ProjectDetail e = new ProjectDetail();
            e.Name = "NEEDS Palace";
            e.CurrentStatus = Status.Completed;
            e.Address = "Plot# 11-12, Lane# 3, Block# C, Mirpur-12, Dhaka-1216";
            e.SizeOfUnits = "1250";
            e.CoverImage = "palace.jpg";
            e.Description = "An exclusive address like no other, where prestige meets sophistication.";
            e.NumberOfFloors = "Ground + 6";
            AllProjectDetails.Add(e);

            // Nirjhora SopnoBilash ( Handover )


        }

        public List<ProjectDetail> GetAllOngoing()
        {
            
            return GetAllByStatus(Status.Ongoing);
        }
        public List<ProjectDetail> GetAllCompleted()
        {

            return GetAllByStatus(Status.Completed);
        }
        public List<ProjectDetail> GetAllUpcoming()
        {

            return GetAllByStatus(Status.Upcoming);
        }
        private List<ProjectDetail> GetAllByStatus(Status enumStatus)
        {
            List<ProjectDetail> projects = new List<ProjectDetail>();
            foreach (var project in AllProjectDetails)
            {
                if (project.CurrentStatus == enumStatus) projects.Add(project);
            }

            return projects;

        }

        public ProjectDetail FindProjectDetailByName(string name)
        {
            foreach (var project in AllProjectDetails )
            {
                if (project.Name.Equals(name)) return project;
            }

            return null;
        }

        public List<ProjectDetail> AllProjectDetail()
        {
            return AllProjectDetails;
        }
    }
}
