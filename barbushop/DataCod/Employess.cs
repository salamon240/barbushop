using barbushop.DataDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barbushop
{
    namespace DataCod
    {
        public class Employess:Barabshops
        {
            public int RolleId { get; set; }
            public int Rolle { get; set; }
            public int Status { get; set; }
            public string starDay { get; set; }

            public Employess()
            {

            }
            public Employess(int rolle ,int status)
            {
                this.Rolle = rolle;
                this.Status = status;
            }

            public  List<Employess> GetEmpUser(int BarbrshopId)
            {
                return EmployessData.GetEmpUser(BarbrshopId);
            }
            public  int DeleteEmp(int EmpID)
            {
               return EmployessData.DeleteEmp(EmpID);
            }
        }

    }
}