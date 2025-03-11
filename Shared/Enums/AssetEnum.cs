using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Enums
{
    public class AssetEnum
    {
        public enum ProjectType
        {
            //Construction,
            //Renovation,
            //Maintenance,
            //Supply,
            //Consultancy
            Maintenance,
            Project,
            Repair,
            Servicing
        }

        public enum MinistryName
        {
            WorksAndHousing,
            Education,
            Health,
            Agriculture,
            Finance,
            Environment,
            Transport,
            Power,
            WaterResources,
            SolidMinerals,
            LabourAndProductivity,
            YouthAndSports,
        }
        public enum AssetStatus
        {
            Approved,
            Pending,
            Rejected,
        }
    }
}
