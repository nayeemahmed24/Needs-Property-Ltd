using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository
{
    public interface IDataStore
    {
        List<ProjectDetail> GetAllUpcoming();
        List<ProjectDetail> GetAllOngoing();
        List<ProjectDetail> GetAllCompleted();
        ProjectDetail FindProjectDetailByName(string name);
        List<ProjectDetail> AllProjectDetail();
    }
}
