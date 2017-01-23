using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Masters
{
    public class CountryMaster
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ComputerName
        {
            get
            {
                return CommonRoutine.GetComputerName();
            }
        }
        public void Insert()
        {
            //Record country info into the db
            CommonRoutine.count++;
            if (!CommonRoutine.IsEmpty(CountryCode) && !CommonRoutine.IsEmpty(CountryName))
            {

            }
        }
    }
}
