using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Customer
{
    public class CustomerClass
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";
        public CustomerClass()
        {
            MachineName = CommonRoutine.GetComputerName();
        }
        //1. We move this unnecessary code to CommonRoutine class
        //public bool IsEmpty(string value)
        //{
        //    if (value.Length == 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public void Insert()
        {
            CommonRoutine.count++;
            if (!CommonRoutine.IsEmpty(CustomerCode) && !CommonRoutine.IsEmpty(CustomerName))
            {

            }
        }
    }
}
